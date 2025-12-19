using MirthConnectVersionControl.Models;

namespace MirthConnectVersionControl.Services.Interfaces
{
    public interface IConfigurationService
    {
        AppConfig CurrentConfig { get; }
        void Save();
        string GetDecryptedConnectionString(string dbType);
        void SetConnectionString(string dbType, string connectionString);
    }
}
