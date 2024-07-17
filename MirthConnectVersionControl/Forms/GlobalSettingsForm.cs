using MirthConnectVersionControl.Utils;

namespace MirthConnectVersionControl
{
	public partial class GlobalSettingsForm : Form
	{
		public GlobalSettingsForm()
		{
			InitializeComponent();
			LogPathTextBox.Text = Properties.Settings.Default.LogPath;
			RepoPathTextBox.Text = Properties.Settings.Default.RepoPath;
			UseGitCheckBox.Checked = Properties.Settings.Default.UseGit;
			CloseOnExitCheckBox.Checked = Properties.Settings.Default.CloseOnExit;
		}

		/// <summary>
		/// Open a dialog to select a path and set the text box to the selected path.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogPathButton_Click(object sender, EventArgs e)
		{
			LogPathTextBox.Text = FileTools.SelectPath() ?? LogPathTextBox.Text;
		}

		/// <summary>
		/// Open a dialog to select a path and set the text box to the selected path.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RepoPathButton_Click(object sender, EventArgs e)
		{
			RepoPathTextBox.Text = FileTools.SelectPath() ?? RepoPathTextBox.Text;
		}

		/// <summary>
		/// Save the settings and close the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.LogPath = LogPathTextBox.Text;
			Properties.Settings.Default.RepoPath = RepoPathTextBox.Text;
			Properties.Settings.Default.UseGit = UseGitCheckBox.Checked;
			Properties.Settings.Default.CloseOnExit = CloseOnExitCheckBox.Checked;
			Properties.Settings.Default.Save();
			Close();
		}

	}
}
