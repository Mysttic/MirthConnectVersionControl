namespace MirthConnectVersionControl
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			MSSQL = new Panel();
			EditMSSQLButton = new Button();
			checkBoxMSSQL = new CheckBox();
			PostgreSQL = new Panel();
			EditPostgreSQLButton = new Button();
			checkBoxPostgreSQL = new CheckBox();
			LogsListBox = new ListBox();
			panel3 = new Panel();
			BrowseLogButton = new Button();
			SettingsButton = new Button();
			MySQL = new Panel();
			EditMySQLButton = new Button();
			checkBoxMySQL = new CheckBox();
			Oracle = new Panel();
			EditOracleButton = new Button();
			checkBoxOracle = new CheckBox();
			splitContainer1 = new SplitContainer();
			MSSQL.SuspendLayout();
			PostgreSQL.SuspendLayout();
			panel3.SuspendLayout();
			MySQL.SuspendLayout();
			Oracle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// MSSQL
			// 
			MSSQL.BorderStyle = BorderStyle.FixedSingle;
			MSSQL.Controls.Add(EditMSSQLButton);
			MSSQL.Controls.Add(checkBoxMSSQL);
			MSSQL.Dock = DockStyle.Top;
			MSSQL.Location = new Point(0, 0);
			MSSQL.Name = "MSSQL";
			MSSQL.Padding = new Padding(5);
			MSSQL.Size = new Size(334, 43);
			MSSQL.TabIndex = 0;
			// 
			// EditMSSQLButton
			// 
			EditMSSQLButton.Dock = DockStyle.Right;
			EditMSSQLButton.Location = new Point(252, 5);
			EditMSSQLButton.Name = "EditMSSQLButton";
			EditMSSQLButton.Size = new Size(75, 31);
			EditMSSQLButton.TabIndex = 1;
			EditMSSQLButton.Text = "Edit";
			EditMSSQLButton.UseVisualStyleBackColor = true;
			EditMSSQLButton.Click += EditButton_Click;
			// 
			// checkBoxMSSQL
			// 
			checkBoxMSSQL.AutoSize = true;
			checkBoxMSSQL.Dock = DockStyle.Left;
			checkBoxMSSQL.Location = new Point(5, 5);
			checkBoxMSSQL.Name = "checkBoxMSSQL";
			checkBoxMSSQL.RightToLeft = RightToLeft.Yes;
			checkBoxMSSQL.Size = new Size(64, 31);
			checkBoxMSSQL.TabIndex = 2;
			checkBoxMSSQL.Text = "MSSQL";
			checkBoxMSSQL.UseVisualStyleBackColor = true;
			checkBoxMSSQL.CheckedChanged += checkBoxMSSQL_CheckedChanged;
			// 
			// PostgreSQL
			// 
			PostgreSQL.BorderStyle = BorderStyle.FixedSingle;
			PostgreSQL.Controls.Add(EditPostgreSQLButton);
			PostgreSQL.Controls.Add(checkBoxPostgreSQL);
			PostgreSQL.Dock = DockStyle.Top;
			PostgreSQL.ImeMode = ImeMode.NoControl;
			PostgreSQL.Location = new Point(0, 43);
			PostgreSQL.Name = "PostgreSQL";
			PostgreSQL.Padding = new Padding(5);
			PostgreSQL.Size = new Size(334, 47);
			PostgreSQL.TabIndex = 2;
			// 
			// EditPostgreSQLButton
			// 
			EditPostgreSQLButton.Dock = DockStyle.Right;
			EditPostgreSQLButton.Location = new Point(252, 5);
			EditPostgreSQLButton.Name = "EditPostgreSQLButton";
			EditPostgreSQLButton.Size = new Size(75, 35);
			EditPostgreSQLButton.TabIndex = 1;
			EditPostgreSQLButton.Text = "Edit";
			EditPostgreSQLButton.UseVisualStyleBackColor = true;
			EditPostgreSQLButton.Click += EditButton_Click;
			// 
			// checkBoxPostgreSQL
			// 
			checkBoxPostgreSQL.AutoSize = true;
			checkBoxPostgreSQL.Dock = DockStyle.Left;
			checkBoxPostgreSQL.Location = new Point(5, 5);
			checkBoxPostgreSQL.Name = "checkBoxPostgreSQL";
			checkBoxPostgreSQL.RightToLeft = RightToLeft.Yes;
			checkBoxPostgreSQL.Size = new Size(87, 35);
			checkBoxPostgreSQL.TabIndex = 2;
			checkBoxPostgreSQL.Text = "PostgreSQL";
			checkBoxPostgreSQL.UseVisualStyleBackColor = true;
			checkBoxPostgreSQL.CheckedChanged += checkboxPostgreSQL_CheckedChanged;
			// 
			// LogsListBox
			// 
			LogsListBox.Dock = DockStyle.Fill;
			LogsListBox.FormattingEnabled = true;
			LogsListBox.HorizontalScrollbar = true;
			LogsListBox.ItemHeight = 15;
			LogsListBox.Location = new Point(0, 0);
			LogsListBox.Name = "LogsListBox";
			LogsListBox.ScrollAlwaysVisible = true;
			LogsListBox.Size = new Size(334, 135);
			LogsListBox.TabIndex = 6;
			// 
			// panel3
			// 
			panel3.Controls.Add(BrowseLogButton);
			panel3.Controls.Add(SettingsButton);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 286);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(5);
			panel3.Size = new Size(334, 36);
			panel3.TabIndex = 7;
			// 
			// BrowseLogButton
			// 
			BrowseLogButton.Dock = DockStyle.Right;
			BrowseLogButton.Location = new Point(254, 5);
			BrowseLogButton.Name = "BrowseLogButton";
			BrowseLogButton.Size = new Size(75, 26);
			BrowseLogButton.TabIndex = 1;
			BrowseLogButton.Text = "Browse log";
			BrowseLogButton.UseVisualStyleBackColor = true;
			BrowseLogButton.Click += BrowseLogButton_Click;
			// 
			// SettingsButton
			// 
			SettingsButton.Dock = DockStyle.Left;
			SettingsButton.Location = new Point(5, 5);
			SettingsButton.Name = "SettingsButton";
			SettingsButton.Size = new Size(75, 26);
			SettingsButton.TabIndex = 0;
			SettingsButton.Text = "Settings";
			SettingsButton.UseVisualStyleBackColor = true;
			SettingsButton.Click += SettingsButton_Click;
			// 
			// MySQL
			// 
			MySQL.BorderStyle = BorderStyle.FixedSingle;
			MySQL.Controls.Add(EditMySQLButton);
			MySQL.Controls.Add(checkBoxMySQL);
			MySQL.Dock = DockStyle.Top;
			MySQL.ImeMode = ImeMode.NoControl;
			MySQL.Location = new Point(0, 90);
			MySQL.Name = "MySQL";
			MySQL.Padding = new Padding(5);
			MySQL.Size = new Size(334, 47);
			MySQL.TabIndex = 8;
			// 
			// EditMySQLButton
			// 
			EditMySQLButton.Dock = DockStyle.Right;
			EditMySQLButton.Location = new Point(252, 5);
			EditMySQLButton.Name = "EditMySQLButton";
			EditMySQLButton.Size = new Size(75, 35);
			EditMySQLButton.TabIndex = 1;
			EditMySQLButton.Text = "Edit";
			EditMySQLButton.UseVisualStyleBackColor = true;
			EditMySQLButton.Click += EditButton_Click;
			// 
			// checkBoxMySQL
			// 
			checkBoxMySQL.AutoSize = true;
			checkBoxMySQL.Dock = DockStyle.Left;
			checkBoxMySQL.Location = new Point(5, 5);
			checkBoxMySQL.Name = "checkBoxMySQL";
			checkBoxMySQL.RightToLeft = RightToLeft.Yes;
			checkBoxMySQL.Size = new Size(64, 35);
			checkBoxMySQL.TabIndex = 2;
			checkBoxMySQL.Text = "MySQL";
			checkBoxMySQL.UseVisualStyleBackColor = true;
			checkBoxMySQL.CheckedChanged += checkboxMySQL_CheckedChanged;
			// 
			// Oracle
			// 
			Oracle.BorderStyle = BorderStyle.FixedSingle;
			Oracle.Controls.Add(EditOracleButton);
			Oracle.Controls.Add(checkBoxOracle);
			Oracle.Dock = DockStyle.Top;
			Oracle.ImeMode = ImeMode.NoControl;
			Oracle.Location = new Point(0, 137);
			Oracle.Name = "Oracle";
			Oracle.Padding = new Padding(5);
			Oracle.Size = new Size(334, 47);
			Oracle.TabIndex = 9;
			// 
			// EditOracleButton
			// 
			EditOracleButton.Dock = DockStyle.Right;
			EditOracleButton.Location = new Point(252, 5);
			EditOracleButton.Name = "EditOracleButton";
			EditOracleButton.Size = new Size(75, 35);
			EditOracleButton.TabIndex = 1;
			EditOracleButton.Text = "Edit";
			EditOracleButton.UseVisualStyleBackColor = true;
			EditOracleButton.Click += EditButton_Click;
			// 
			// checkBoxOracle
			// 
			checkBoxOracle.AutoSize = true;
			checkBoxOracle.Dock = DockStyle.Left;
			checkBoxOracle.Location = new Point(5, 5);
			checkBoxOracle.Name = "checkBoxOracle";
			checkBoxOracle.RightToLeft = RightToLeft.Yes;
			checkBoxOracle.Size = new Size(60, 35);
			checkBoxOracle.TabIndex = 2;
			checkBoxOracle.Text = "Oracle";
			checkBoxOracle.UseVisualStyleBackColor = true;
			checkBoxOracle.CheckedChanged += checkboxOracle_CheckedChanged;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(Oracle);
			splitContainer1.Panel1.Controls.Add(MySQL);
			splitContainer1.Panel1.Controls.Add(PostgreSQL);
			splitContainer1.Panel1.Controls.Add(MSSQL);
			splitContainer1.Panel1.Controls.Add(panel3);
			splitContainer1.Panel1MinSize = 250;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(LogsListBox);
			splitContainer1.Size = new Size(334, 461);
			splitContainer1.SplitterDistance = 322;
			splitContainer1.TabIndex = 10;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(334, 461);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(200, 500);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MirthConnectVersionControl";
			MSSQL.ResumeLayout(false);
			MSSQL.PerformLayout();
			PostgreSQL.ResumeLayout(false);
			PostgreSQL.PerformLayout();
			panel3.ResumeLayout(false);
			MySQL.ResumeLayout(false);
			MySQL.PerformLayout();
			Oracle.ResumeLayout(false);
			Oracle.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel MSSQL;
		private Button EditMSSQLButton;
		public CheckBox checkBoxMSSQL;
		private Panel PostgreSQL;
		private Button EditPostgreSQLButton;
		public CheckBox checkBoxPostgreSQL;
		public ListBox LogsListBox;
		private Panel panel3;
		private Button SettingsButton;
		private Button BrowseLogButton;
		private Panel MySQL;
		private Button EditMySQLButton;
		public CheckBox checkBoxMySQL;
		private Panel Oracle;
		private Button EditOracleButton;
		public CheckBox checkBoxOracle;
		private SplitContainer splitContainer1;
	}
}
