using MirthConnectVersionControl.Services.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MirthConnectVersionControl
{
    public partial class MainForm : Form
    {
        private readonly IDatabaseService _dbService;
        private readonly IConfigurationService _configService;
        private readonly ILoggingService _logger;
        private readonly IGitService _git;

        private bool _forceClose = false;

        // Default Constructor for Designer support (though custom DI constructor is used in Program.cs)
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IDatabaseService db, IConfigurationService config, ILoggingService logger, IGitService git) : this()
        {
            _dbService = db;
            _configService = config;
            _logger = logger;
            _git = git;

            InitializeCustom();
        }

        private void InitializeCustom()
        {
            // Set Icons from Resources
            try {
                var icon = MirthConnectVersionControl.Properties.Resources.MCVCicon;
                this.Icon = icon;
                notifyIcon1.Icon = icon;
            } catch { /* use default if missing */ }

            // Subscribe to Logger
            _logger.LogReceived += OnLogReceived;

            // Load UI
            LoadConfigToUI();
        }

        private void OnLogReceived(string msg)
        {
            if (rtbLogs.InvokeRequired)
            {
                rtbLogs.Invoke(new Action<string>(OnLogReceived), msg);
                return;
            }

            rtbLogs.AppendText(msg + Environment.NewLine);
            rtbLogs.ScrollToCaret();
        }

        private void LoadConfigToUI()
        {
            var conf = _configService.CurrentConfig;
            cmbDbType.SelectedItem = conf.SelectedDatabase;
            txtRepoPath.Text = conf.RepoPath;
            chkUseGit.Checked = conf.UseGit;
            chkCloseOnExit.Checked = conf.CloseOnExit;

            UpdateConnectionStringInput();
        }

        private void UpdateConnectionStringInput()
        {
            string type = cmbDbType.SelectedItem?.ToString() ?? "MSSQL";
            txtConnString.Text = _configService.GetDecryptedConnectionString(type);
        }

        private void cmbDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConnectionStringInput();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dbType = cmbDbType.SelectedItem?.ToString() ?? "MSSQL";
            
            _configService.CurrentConfig.SelectedDatabase = dbType;
            _configService.CurrentConfig.RepoPath = txtRepoPath.Text;
            _configService.CurrentConfig.UseGit = chkUseGit.Checked;
            _configService.CurrentConfig.CloseOnExit = chkCloseOnExit.Checked;

            // Save encrypted connection string
            _configService.SetConnectionString(dbType, txtConnString.Text);
            
            _configService.Save();
            MessageBox.Show("Configuration Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            string dbType = cmbDbType.SelectedItem?.ToString() ?? "MSSQL";
            string connStr = txtConnString.Text;

            btnTestConnection.Enabled = false;
            btnTestConnection.Text = "Testing...";

            bool result = await _dbService.TestConnection(dbType, connStr);

            btnTestConnection.Enabled = true;
            btnTestConnection.Text = "Test Connection";

            if (result)
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Connection Failed. Check logs for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowseRepo_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtRepoPath.Text = fbd.SelectedPath;
                }
            }
        }

        private async void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_dbService.IsRunning)
            {
                _dbService.StopListener();
                btnStartStop.Text = "Start Listener";
                lblStatus.Text = "Status: Stopped";
                lblStatus.ForeColor = Color.DimGray;
                lblStatus.BackColor = Color.Transparent;
                
                notifyIcon1.Text = "MCVC - Stopped";
                // Optionally change Icon
            }
            else
            {
                // Ensure Config is saved/current before starting
                btnSave_Click(sender, e);
                
                btnStartStop.Enabled = false;
                await _dbService.StartListener();
                btnStartStop.Enabled = true;
                
                if (_dbService.IsRunning)
                {
                    btnStartStop.Text = "Stop Listener";
                    lblStatus.Text = "Status: RUNNING";
                    lblStatus.ForeColor = Color.LimeGreen;
                    
                    notifyIcon1.Text = "MCVC - Running";
                }
            }
        }

        #region Tray & Closing Logic

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_forceClose || _configService.CurrentConfig.CloseOnExit)
            {
                _dbService.StopListener();
                notifyIcon1.Visible = false;
                return;
            }

            e.Cancel = true;
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000, "MCVC", "Application minimized to tray.", ToolTipIcon.Info);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            _forceClose = true;
            Application.Exit();
        }

        #endregion
    }
}
