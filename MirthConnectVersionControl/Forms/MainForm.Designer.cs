namespace MirthConnectVersionControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.grpRepository = new System.Windows.Forms.GroupBox();
            this.chkCloseOnExit = new System.Windows.Forms.CheckBox();
            this.chkUseGit = new System.Windows.Forms.CheckBox();
            this.btnBrowseRepo = new System.Windows.Forms.Button();
            this.txtRepoPath = new System.Windows.Forms.TextBox();
            this.lblRepoPath = new System.Windows.Forms.Label();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.grpRepository.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabDashboard);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.rtbLogs);
            this.tabDashboard.Controls.Add(this.panelTop);
            this.tabDashboard.Location = new System.Drawing.Point(4, 24);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(592, 422);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // rtbLogs
            // 
            this.rtbLogs.BackColor = System.Drawing.Color.Black;
            this.rtbLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbLogs.ForeColor = System.Drawing.Color.Lime;
            this.rtbLogs.HideSelection = false;
            this.rtbLogs.Location = new System.Drawing.Point(3, 53);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.Size = new System.Drawing.Size(586, 366);
            this.rtbLogs.TabIndex = 1;
            this.rtbLogs.Text = "Waiting for service...";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.btnStartStop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(586, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(135, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 21);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Stopped";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(14, 9);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(115, 33);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start Listener";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.grpRepository);
            this.tabSettings.Controls.Add(this.grpDatabase);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(592, 422);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // grpRepository
            // 
            this.grpRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRepository.Controls.Add(this.chkCloseOnExit);
            this.grpRepository.Controls.Add(this.chkUseGit);
            this.grpRepository.Controls.Add(this.btnBrowseRepo);
            this.grpRepository.Controls.Add(this.txtRepoPath);
            this.grpRepository.Controls.Add(this.lblRepoPath);
            this.grpRepository.Location = new System.Drawing.Point(8, 209);
            this.grpRepository.Name = "grpRepository";
            this.grpRepository.Size = new System.Drawing.Size(576, 126);
            this.grpRepository.TabIndex = 1;
            this.grpRepository.TabStop = false;
            this.grpRepository.Text = "Repository & General";
            // 
            // chkCloseOnExit
            // 
            this.chkCloseOnExit.AutoSize = true;
            this.chkCloseOnExit.Location = new System.Drawing.Point(23, 89);
            this.chkCloseOnExit.Name = "chkCloseOnExit";
            this.chkCloseOnExit.Size = new System.Drawing.Size(262, 19);
            this.chkCloseOnExit.TabIndex = 4;
            this.chkCloseOnExit.Text = "Close completely on Exit (Don\'t force minimize)";
            this.chkCloseOnExit.UseVisualStyleBackColor = true;
            // 
            // chkUseGit
            // 
            this.chkUseGit.AutoSize = true;
            this.chkUseGit.Checked = true;
            this.chkUseGit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseGit.Location = new System.Drawing.Point(23, 64);
            this.chkUseGit.Name = "chkUseGit";
            this.chkUseGit.Size = new System.Drawing.Size(183, 19);
            this.chkUseGit.TabIndex = 3;
            this.chkUseGit.Text = "Enable Git Version Control";
            this.chkUseGit.UseVisualStyleBackColor = true;
            // 
            // btnBrowseRepo
            // 
            this.btnBrowseRepo.Location = new System.Drawing.Point(525, 34);
            this.btnBrowseRepo.Name = "btnBrowseRepo";
            this.btnBrowseRepo.Size = new System.Drawing.Size(35, 23);
            this.btnBrowseRepo.TabIndex = 2;
            this.btnBrowseRepo.Text = "...";
            this.btnBrowseRepo.UseVisualStyleBackColor = true;
            this.btnBrowseRepo.Click += new System.EventHandler(this.btnBrowseRepo_Click);
            // 
            // txtRepoPath
            // 
            this.txtRepoPath.Location = new System.Drawing.Point(111, 35);
            this.txtRepoPath.Name = "txtRepoPath";
            this.txtRepoPath.Size = new System.Drawing.Size(408, 23);
            this.txtRepoPath.TabIndex = 1;
            // 
            // lblRepoPath
            // 
            this.lblRepoPath.AutoSize = true;
            this.lblRepoPath.Location = new System.Drawing.Point(23, 38);
            this.lblRepoPath.Name = "lblRepoPath";
            this.lblRepoPath.Size = new System.Drawing.Size(66, 15);
            this.lblRepoPath.TabIndex = 0;
            this.lblRepoPath.Text = "Repo Path:";
            // 
            // grpDatabase
            // 
            this.grpDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatabase.Controls.Add(this.btnSave);
            this.grpDatabase.Controls.Add(this.btnTestConnection);
            this.grpDatabase.Controls.Add(this.txtConnString);
            this.grpDatabase.Controls.Add(this.label2);
            this.grpDatabase.Controls.Add(this.cmbDbType);
            this.grpDatabase.Controls.Add(this.label1);
            this.grpDatabase.Location = new System.Drawing.Point(8, 6);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(576, 197);
            this.grpDatabase.TabIndex = 0;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "Database Configuration";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Configuration";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(445, 150);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(115, 32);
            this.btnTestConnection.TabIndex = 4;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(111, 74);
            this.txtConnString.Multiline = true;
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.PasswordChar = '*';
            this.txtConnString.Size = new System.Drawing.Size(449, 60);
            this.txtConnString.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection \r\nString:";
            // 
            // cmbDbType
            // 
            this.cmbDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDbType.FormattingEnabled = true;
            this.cmbDbType.Items.AddRange(new object[] {
            "MSSQL",
            "PostgreSQL",
            "MySQL",
            "Oracle"});
            this.cmbDbType.Location = new System.Drawing.Point(111, 35);
            this.cmbDbType.Name = "cmbDbType";
            this.cmbDbType.Size = new System.Drawing.Size(183, 23);
            this.cmbDbType.TabIndex = 1;
            this.cmbDbType.SelectedIndexChanged += new System.EventHandler(this.cmbDbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Type:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "MCVC - Stopped";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "MirthConnect Version Control 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.grpRepository.ResumeLayout(false);
            this.grpRepository.PerformLayout();
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.ComboBox cmbDbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpRepository;
        private System.Windows.Forms.Button btnBrowseRepo;
        private System.Windows.Forms.TextBox txtRepoPath;
        private System.Windows.Forms.Label lblRepoPath;
        private System.Windows.Forms.CheckBox chkUseGit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.CheckBox chkCloseOnExit;
    }
}
