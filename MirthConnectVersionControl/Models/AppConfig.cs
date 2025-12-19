namespace MirthConnectVersionControl.Models
{
    public class AppConfig
    {
        public string SelectedDatabase { get; set; } = "MSSQL"; // MSSQL, PostgreSQL, MySQL, Oracle
        public bool UseGit { get; set; } = true;
        public string RepoPath { get; set; } = "";
        public bool CloseOnExit { get; set; } = false;

        public Dictionary<string, DbConfig> Databases { get; set; } = new Dictionary<string, DbConfig>();

        public AppConfig()
        {
            // Defaults
            Databases["MSSQL"] = new DbConfig();
            Databases["PostgreSQL"] = new DbConfig();
            Databases["MySQL"] = new DbConfig();
            Databases["Oracle"] = new DbConfig();
        }
    }

    public class DbConfig
    {
        public string ConnectionString { get; set; } = "";

        public int IntervalSeconds { get; set; } = 5;
        public string IdColumn { get; set; } = "Id";
        public string NameColumn { get; set; } = "Name";
        public string RevisionColumn { get; set; } = "Revision";
        public string ContentColumn { get; set; } = "Content";
    }
}
