namespace MirthConnectVersionControl.Utils
{
	internal static class FileTools
	{
		/// <summary>
		/// Select a file
		/// </summary>
		/// <returns></returns>
		public static string SelectPath()
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = "Select folder";
				folderBrowserDialog.ShowNewFolderButton = true;

				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					return folderBrowserDialog.SelectedPath;
				}
			}
			return null;
		}
	}
}
