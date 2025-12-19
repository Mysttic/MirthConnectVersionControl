namespace MirthConnectVersionControl.Services.Interfaces
{
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogError(string message, Exception? ex = null);
        void LogWarning(string message);
        event Action<string> LogReceived;
    }
}
