using MirthConnectVersionControl.DatabaseTools;
using MirthConnectVersionControl.Properties;
using System.ComponentModel;
using System.Diagnostics;

namespace MirthConnectVersionControl
{
    public partial class MainForm : Form
	{
		#region Properties

		private NotifyIcon notifyIcon;
		MSSQLListener mssqlListener { get; set; }
		PostgreSQLListener postgresqlListener { get; set; }
		MySQLListener mysqlListener { get; set; }
		OracleListener oracleListener { get; set; }

		#endregion Properties

		#region Methods

		public MainForm()
		{
			InitializeComponent();
			InitializeNotifyIcon();
			mssqlListener = new MSSQLListener(this);
			postgresqlListener = new PostgreSQLListener(this);
			mysqlListener = new MySQLListener(this);
			oracleListener = new OracleListener(this);
		}

		/// <summary>
		/// Initialize the NotifyIcon
		/// </summary>
		private void InitializeNotifyIcon()
		{
			notifyIcon = new NotifyIcon();
			notifyIcon.Icon = Icon.FromHandle(Resources.MCVClogo.GetHicon());
			notifyIcon.Text = "MirthConnectVersionControl";
			notifyIcon.Visible = true;

			ContextMenuStrip contextMenu = new ContextMenuStrip();
			contextMenu.Items.Add("Open", null, Open_Click);
			contextMenu.Items.Add("Exit", null, Exit_Click);
			notifyIcon.ContextMenuStrip = contextMenu;
			notifyIcon.DoubleClick += Open_Click;
		}

		#endregion Methods

		#region Events

		/// <summary>
		/// Open the form when the NotifyIcon is double clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Open_Click(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		/// <summary>
		/// Exit the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Exit_Click(object sender, EventArgs e)
		{
			notifyIcon.Visible = false;
			Application.Exit();
		}

		/// <summary>
		/// Minimize the form to the system tray when the form is minimized
		/// </summary>
		/// <param name="e"></param>
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		/// <summary>
		/// Close the form when the close button is clicked
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosing(CancelEventArgs e)
		{
			if (Settings.Default.CloseOnExit)
				base.OnClosing(e);
			else
			{
				e.Cancel = true;
				this.WindowState = FormWindowState.Minimized;
				this.Hide();
			}
		}

		/// <summary>
		/// Open the form when the NotifyIcon is double clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditButton_Click(object sender, EventArgs e)
		{
			switch ((sender as Button)?.Name)
			{
				case "EditMSSQLButton":
					new EditSettingForm(
						"MSSQL", 
						DbSettings.Default.MSSQL
						).ShowDialog();
					break;
				case "EditPostgreSQLButton":
					new EditSettingForm(
						"PostgreSQL", 
						DbSettings.Default.PostgreSQL
						).ShowDialog();
					break;
				case "EditMySQLButton":
					new EditSettingForm(
						"MySQL",
						DbSettings.Default.MySQL
						).ShowDialog();
					break;
				case "OracleButton":
					new EditSettingForm(
						"Oracle",
						DbSettings.Default.Oracle
						).ShowDialog();
					break;
			}
		}

		/// <summary>
		/// Start or stop the listener when the checkbox is checked or unchecked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBoxMSSQL_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox)?.Checked == true)			
				mssqlListener.Start();			
			else 			
				mssqlListener.Stop(); 			
		}

		/// <summary>
		/// Start or stop the listener when the checkbox is checked or unchecked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkboxPostgreSQL_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox)?.Checked == true)
				postgresqlListener.Start();
			else
				postgresqlListener.Stop();
		}

		/// <summary>
		/// Start or stop the listener when the checkbox is checked or unchecked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkboxMySQL_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox)?.Checked == true)
				mysqlListener.Start();
			else
				mysqlListener.Stop();
		}

		/// <summary>
		/// Start or stop the listener when the checkbox is checked or unchecked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkboxOracle_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox)?.Checked == true)
				oracleListener.Start();
			else
				oracleListener.Stop();
		}

		/// <summary>
		/// Open the settings form when the settings button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SettingsButton_Click(object sender, EventArgs e)
		{
			new GlobalSettingsForm().ShowDialog();
		}

		/// <summary>
		/// Open the log file when the browse log button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowseLogButton_Click(object sender, EventArgs e)
		{
			if (Path.Exists(Settings.Default.LogPath))
				Process.Start(new ProcessStartInfo
				{
					FileName = Settings.Default.LogPath,
					UseShellExecute = true,
					Verb = "open"
				});
			else
				MessageBox.Show("Log path not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion Events
	}
}
