using MirthConnectVersionControl.Services.Interfaces;
using Serilog;

namespace MirthConnectVersionControl.Services
{
    public class LoggingService : ILoggingService
    {
        public LoggingService()
        {
            string logPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MirthConnectVersionControl",
                "Logs",
                "log-.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                .CreateLogger();
        }

        public event Action<string> LogReceived;

        public void LogInfo(string message)
        {
            Log.Information(message);
            LogReceived?.Invoke($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [INFO] {message}");
        }

        public void LogError(string message, Exception? ex = null)
        {
            if (ex != null)
            {
                Log.Error(ex, message);
                LogReceived?.Invoke($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [ERROR] {message} : {ex.Message}");
            }
            else
            {
                Log.Error(message);
                LogReceived?.Invoke($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [ERROR] {message}");
            }
        }

        public void LogWarning(string message)
        {
            Log.Warning(message);
            LogReceived?.Invoke($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [WARN] {message}");
        }
    }
}
