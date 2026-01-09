using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using MirthConnectVersionControl.Services.Interfaces;
using MirthConnectVersionControl.Models;

namespace MirthConnectVersionControl.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IConfigurationService _config;
        private readonly ILoggingService _logger;
        private readonly IGitService _git;

        private CancellationTokenSource? _cts;
        private Task? _listenerTask;

        public bool IsRunning => _listenerTask != null && !_listenerTask.IsCompleted;

        public DatabaseService(IConfigurationService config, ILoggingService logger, IGitService git)
        {
            _config = config;
            _logger = logger;
            _git = git;
        }

        public string GetActiveDatabaseType() => _config.CurrentConfig.SelectedDatabase;

        public async Task StartListener()
        {
            if (IsRunning) return;

            string dbType = _config.CurrentConfig.SelectedDatabase;
            if (!_config.CurrentConfig.Databases.ContainsKey(dbType))
            {
                _logger.LogError($"Configuration for {dbType} not found.");
                return;
            }

            _cts = new CancellationTokenSource();
            _listenerTask = ListenerLoop(dbType, _cts.Token);
            _logger.LogInfo($"Started listener for {dbType}");
            await Task.CompletedTask;
        }

        public void StopListener()
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
                _logger.LogInfo("Stopping listener...");
            }
        }

        // Queries for each table type per database
        private static readonly Dictionary<string, Dictionary<string, string>> _tableQueries = new()
        {
            { "MSSQL", new Dictionary<string, string> {
                { "channel", "SELECT Id, Name, Revision, Content FROM CHANNEL" },
                { "code_template", "SELECT Id, Name, Revision, Content FROM CODE_TEMPLATE" }
            }},
            { "PostgreSQL", new Dictionary<string, string> {
                { "channel", "SELECT id, name, revision, content FROM channel" },
                { "code_template", "SELECT id, name, revision, content FROM code_template" }
            }},
            { "MySQL", new Dictionary<string, string> {
                { "channel", "SELECT Id, Name, Revision, Content FROM CHANNEL" },
                { "code_template", "SELECT Id, Name, Revision, Content FROM CODE_TEMPLATE" }
            }},
            { "Oracle", new Dictionary<string, string> {
                { "channel", "SELECT Id, Name, Revision, Content FROM CHANNEL" },
                { "code_template", "SELECT Id, Name, Revision, Content FROM CODE_TEMPLATE" }
            }}
        };

        private async Task ListenerLoop(string dbType, CancellationToken token)
        {
            var dbConfig = _config.CurrentConfig.Databases[dbType];
            string? connStr = _config.GetDecryptedConnectionString(dbType);

            if (string.IsNullOrEmpty(connStr))
            {
                _logger.LogError($"Connection string for {dbType} is empty.");
                return;
            }

            if (!_tableQueries.TryGetValue(dbType, out var tableQueries))
            {
                _logger.LogError($"No queries defined for {dbType}.");
                return;
            }

            // Separate cache for each table type
            Dictionary<string, Dictionary<string, string>> caches = new()
            {
                { "channel", new Dictionary<string, string>() },
                { "code_template", new Dictionary<string, string>() }
            };

            while (!token.IsCancellationRequested)
            {
                DbConnection? conn = null;
                try
                {
                    conn = CreateConnection(dbType, connStr);
                    await conn.OpenAsync(token);

                    // Process each table type
                    foreach (var tableEntry in tableQueries)
                    {
                        string tableType = tableEntry.Key;
                        string sqlQuery = tableEntry.Value;
                        var cache = caches[tableType];

                        try
                        {
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = sqlQuery;

                                using (var reader = await command.ExecuteReaderAsync(token))
                                {
                                    while (await reader.ReadAsync(token))
                                    {
                                        string id = GetValue(reader, dbConfig.IdColumn, 0);
                                        string name = GetValue(reader, dbConfig.NameColumn, 1);
                                        string revision = GetValue(reader, dbConfig.RevisionColumn, 2);
                                        string content = GetValue(reader, dbConfig.ContentColumn, 3);

                                        string cacheKey = $"{tableType}_{id}";

                                        if (!cache.TryGetValue(id, out var cachedRev))
                                        {
                                            cache[id] = revision;
                                            _logger.LogInfo($"New {tableType}: {name} (Rev: {revision})");
                                            _git.ProcessChange(dbType, tableType, id, name, revision, content);
                                        }
                                        else if (cachedRev != revision)
                                        {
                                            cache[id] = revision;
                                            _logger.LogInfo($"Updated {tableType}: {name} (Rev: {revision})");
                                            _git.ProcessChange(dbType, tableType, id, name, revision, content);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex) when (ex.Message.Contains("nie istnieje") || ex.Message.Contains("does not exist"))
                        {
                            // Table doesn't exist in this database - skip silently
                            // This allows monitoring databases that don't have code_template table
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error in listener loop: {ex.Message}", ex);
                    // Wait a bit longer on error
                    try { await Task.Delay(10000, token); } catch { }
                }
                finally
                {
                    if (conn != null) conn.Dispose();
                }

                try
                {
                    await Task.Delay(dbConfig.IntervalSeconds * 1000, token);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
            _logger.LogInfo("Listener stopped.");
        }

        private string GetValue(DbDataReader reader, string colName, int indexFallback)
        {
            try
            {
                int ordinal = reader.GetOrdinal(colName);
                return reader[ordinal]?.ToString() ?? "";
            }
            catch
            {
                if (reader.FieldCount > indexFallback)
                    return reader[indexFallback]?.ToString() ?? "";
                return "";
            }
        }

        public async Task<bool> TestConnection(string dbType, string connectionString)
        {
            try
            {
                using (var conn = CreateConnection(dbType, connectionString))
                {
                    await conn.OpenAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Connection test failed for {dbType}: {ex.Message}");
                return false;
            }
        }

        private DbConnection CreateConnection(string dbType, string connectionString)
        {
            return dbType switch
            {
                "MSSQL" => new SqlConnection(connectionString),
                "MySQL" => new MySqlConnection(connectionString),
                "PostgreSQL" => new NpgsqlConnection(connectionString),
                "Oracle" => new OracleConnection(connectionString),
                _ => throw new ArgumentException("Invalid Database Type")
            };
        }
    }
}
