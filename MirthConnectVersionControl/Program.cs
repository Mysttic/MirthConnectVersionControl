using Microsoft.IdentityModel.Tokens;

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
			InitializeCatalogs();
			Application.Run(new MainForm());
		}

		/// <summary>
		/// Initialize the application catalogs
		/// </summary>
		internal static void InitializeCatalogs()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.LogPath))
			{
				Properties.Settings.Default.LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MirthConnectVersionControl", "Logs");
				Properties.Settings.Default.Save();
				if (!Directory.Exists(Properties.Settings.Default.LogPath))
					Directory.CreateDirectory(Properties.Settings.Default.LogPath);
			}			
			if (string.IsNullOrEmpty(Properties.Settings.Default.RepoPath))
			{
				Properties.Settings.Default.RepoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MirthConnectVersionControl", "Repository");
				Properties.Settings.Default.Save();
				if (!Directory.Exists(Properties.Settings.Default.RepoPath))
					Directory.CreateDirectory(Properties.Settings.Default.RepoPath);
			}
			
		}
	}
}