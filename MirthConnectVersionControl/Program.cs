using MirthConnectVersionControl.Services;
using MirthConnectVersionControl.Services.Interfaces;

namespace MirthConnectVersionControl
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			// Composition Root (Manual DI)
			IEncryptionService encryption = new EncryptionService();
			IConfigurationService config = new ConfigurationService(encryption);
			ILoggingService logger = new LoggingService();
			IGitService git = new GitService(config, logger);
			IDatabaseService db = new DatabaseService(config, logger, git);

			Application.Run(new MainForm(db, config, logger, git));
		}
	}
}