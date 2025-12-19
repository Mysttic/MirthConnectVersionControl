using MirthConnectVersionControl.Models;
using MirthConnectVersionControl.Services.Interfaces;
using Newtonsoft.Json;

namespace MirthConnectVersionControl.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IEncryptionService _encryptionService;
        private readonly string _configPath;
        public AppConfig CurrentConfig { get; private set; }

        public ConfigurationService(IEncryptionService encryptionService)
        {
            _encryptionService = encryptionService;
            string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MirthConnectVersionControl");
            if (!Directory.Exists(appData)) Directory.CreateDirectory(appData);
            
            _configPath = Path.Combine(appData, "config.json");
            Load();
        }

        private void Load()
        {
            if (File.Exists(_configPath))
            {
                try
                {
                    string json = File.ReadAllText(_configPath);
                    CurrentConfig = JsonConvert.DeserializeObject<AppConfig>(json) ?? new AppConfig();
                }
                catch
                {
                    CurrentConfig = new AppConfig();
                }
            }
            else
            {
                CurrentConfig = new AppConfig();
                // Initialize default repo path
                CurrentConfig.RepoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MirthConnectVersionControl", "Repository");
                Save();
            }
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(CurrentConfig, Formatting.Indented);
            File.WriteAllText(_configPath, json);
        }

        public string GetDecryptedConnectionString(string dbType)
        {
            if (CurrentConfig.Databases.TryGetValue(dbType, out var config))
            {
                return _encryptionService.Decrypt(config.ConnectionString);
            }
            return string.Empty;
        }

        public void SetConnectionString(string dbType, string connectionString)
        {
            if (CurrentConfig.Databases.ContainsKey(dbType))
            {
                CurrentConfig.Databases[dbType].ConnectionString = _encryptionService.Encrypt(connectionString);
            }
        }
    }
}
