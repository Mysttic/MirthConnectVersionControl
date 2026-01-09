using LibGit2Sharp;
using MirthConnectVersionControl.Services.Interfaces;

namespace MirthConnectVersionControl.Services
{
    public class GitService : IGitService
    {
        private readonly IConfigurationService _config;
        private readonly ILoggingService _logger;

        public GitService(IConfigurationService config, ILoggingService logger)
        {
            _config = config;
            _logger = logger;
        }

        public bool IsRepositoryValid()
        {
            return Repository.IsValid(_config.CurrentConfig.RepoPath);
        }

        public void InitializeRepository()
        {
            string path = _config.CurrentConfig.RepoPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!Repository.IsValid(path))
            {
                Repository.Init(path);
                _logger.LogInfo($"New repository created at {path}");
            }
        }

        public void ProcessChange(string dbType, string tableType, string id, string name, string revision, string content)
        {
            try
            {
                string repoPath = _config.CurrentConfig.RepoPath;

                // Organize by database type and table type (e.g., PostgreSQL/channels, PostgreSQL/code_templates)
                string tableFolder = tableType == "channel" ? "channels" : "code_templates";
                string targetFolder = Path.Combine(repoPath, dbType, tableFolder);

                if (!Directory.Exists(targetFolder))
                    Directory.CreateDirectory(targetFolder);

                string fileName = name;
                if (!_config.CurrentConfig.UseGit)
                {
                    // If not using Git features fully (just file dump), append timestamp/rev
                    fileName = $"{name}_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}_Rev{revision}";
                }

                // Sanitize filename
                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(c, '_');
                }

                string filePath = Path.Combine(targetFolder, fileName);
                File.WriteAllText(filePath, content);

                if (_config.CurrentConfig.UseGit)
                {
                    if (!IsRepositoryValid())
                        InitializeRepository();

                    using (var repo = new Repository(repoPath))
                    {
                        Commands.Stage(repo, filePath);

                        // Check if changes exist to commit
                        var status = repo.RetrieveStatus();
                        if (status.IsDirty)
                        {
                            var author = new Signature("MCVC", "mcvc@local", DateTime.Now);
                            string itemType = tableType == "channel" ? "channel" : "code template";
                            repo.Commit($"Update {itemType} '{name}' (Rev: {revision})", author, author);
                            _logger.LogInfo($"Committed changes for {itemType} '{name}' (Rev: {revision})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to process change for {name}", ex);
            }
        }
    }
}
