namespace MirthConnectVersionControl.Services.Interfaces
{
    public interface IDatabaseService
    {
        Task StartListener();
        void StopListener();
        bool IsRunning { get; }
        Task<bool> TestConnection(string dbType, string connectionString);
        string GetActiveDatabaseType();
    }
}
