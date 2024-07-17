namespace MirthConnectVersionControl
{
	partial class GlobalSettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettingsForm));
			Log = new Panel();
			LogPathTextBox = new TextBox();
			label1 = new Label();
			LogPathButton = new Button();
			Repo = new Panel();
			RepoPathTextBox = new TextBox();
			label2 = new Label();
			RepoPathButton = new Button();
			SaveButton = new Button();
			panel3 = new Panel();
			CloseOnExitCheckBox = new CheckBox();
			UseGitCheckBox = new CheckBox();
			Log.SuspendLayout();
			Repo.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// Log
			// 
			Log.Controls.Add(LogPathTextBox);
			Log.Controls.Add(label1);
			Log.Controls.Add(LogPathButton);
			Log.Dock = DockStyle.Top;
			Log.Location = new Point(5, 5);
			Log.Name = "Log";
			Log.Padding = new Padding(10);
			Log.Size = new Size(474, 60);
			Log.TabIndex = 0;
			// 
			// LogPathTextBox
			// 
			LogPathTextBox.Dock = DockStyle.Top;
			LogPathTextBox.Location = new Point(10, 25);
			LogPathTextBox.Name = "LogPathTextBox";
			LogPathTextBox.Size = new Size(385, 23);
			LogPathTextBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(10, 10);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 0;
			label1.Text = "Log path";
			// 
			// LogPathButton
			// 
			LogPathButton.Dock = DockStyle.Right;
			LogPathButton.Location = new Point(395, 10);
			LogPathButton.Name = "LogPathButton";
			LogPathButton.Size = new Size(69, 40);
			LogPathButton.TabIndex = 2;
			LogPathButton.Text = "Browse";
			LogPathButton.UseVisualStyleBackColor = true;
			LogPathButton.Click += LogPathButton_Click;
			// 
			// Repo
			// 
			Repo.Controls.Add(RepoPathTextBox);
			Repo.Controls.Add(label2);
			Repo.Controls.Add(RepoPathButton);
			Repo.Dock = DockStyle.Top;
			Repo.Location = new Point(5, 65);
			Repo.Name = "Repo";
			Repo.Padding = new Padding(10);
			Repo.Size = new Size(474, 60);
			Repo.TabIndex = 3;
			// 
			// RepoPathTextBox
			// 
			RepoPathTextBox.Dock = DockStyle.Top;
			RepoPathTextBox.Location = new Point(10, 25);
			RepoPathTextBox.Name = "RepoPathTextBox";
			RepoPathTextBox.Size = new Size(385, 23);
			RepoPathTextBox.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(10, 10);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 0;
			label2.Text = "Repo path";
			// 
			// RepoPathButton
			// 
			RepoPathButton.Dock = DockStyle.Right;
			RepoPathButton.Location = new Point(395, 10);
			RepoPathButton.Name = "RepoPathButton";
			RepoPathButton.Size = new Size(69, 40);
			RepoPathButton.TabIndex = 2;
			RepoPathButton.Text = "Browse";
			RepoPathButton.UseVisualStyleBackColor = true;
			RepoPathButton.Click += RepoPathButton_Click;
			// 
			// SaveButton
			// 
			SaveButton.Dock = DockStyle.Bottom;
			SaveButton.Location = new Point(5, 375);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(474, 31);
			SaveButton.TabIndex = 4;
			SaveButton.Text = "Save";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(CloseOnExitCheckBox);
			panel3.Controls.Add(UseGitCheckBox);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(5, 125);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(10);
			panel3.Size = new Size(474, 46);
			panel3.TabIndex = 5;
			// 
			// CloseOnExitCheckBox
			// 
			CloseOnExitCheckBox.AutoSize = true;
			CloseOnExitCheckBox.Dock = DockStyle.Left;
			CloseOnExitCheckBox.Location = new Point(72, 10);
			CloseOnExitCheckBox.Name = "CloseOnExitCheckBox";
			CloseOnExitCheckBox.Size = new Size(94, 26);
			CloseOnExitCheckBox.TabIndex = 2;
			CloseOnExitCheckBox.Text = "Close on exit";
			CloseOnExitCheckBox.UseVisualStyleBackColor = true;
			// 
			// UseGitCheckBox
			// 
			UseGitCheckBox.AutoSize = true;
			UseGitCheckBox.Dock = DockStyle.Left;
			UseGitCheckBox.Location = new Point(10, 10);
			UseGitCheckBox.Name = "UseGitCheckBox";
			UseGitCheckBox.Size = new Size(62, 26);
			UseGitCheckBox.TabIndex = 1;
			UseGitCheckBox.Text = "Use git";
			UseGitCheckBox.UseVisualStyleBackColor = true;
			// 
			// GlobalSettingsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 411);
			Controls.Add(panel3);
			Controls.Add(SaveButton);
			Controls.Add(Repo);
			Controls.Add(Log);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(250, 320);
			Name = "GlobalSettingsForm";
			Padding = new Padding(5);
			StartPosition = FormStartPosition.CenterParent;
			Text = "Global Settings";
			Log.ResumeLayout(false);
			Log.PerformLayout();
			Repo.ResumeLayout(false);
			Repo.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel Log;
		private TextBox LogPathTextBox;
		private Label label1;
		private Button LogPathButton;
		private Panel Repo;
		private TextBox RepoPathTextBox;
		private Label label2;
		private Button RepoPathButton;
		private Button SaveButton;
		private Panel panel3;
		private CheckBox UseGitCheckBox;
		private CheckBox CloseOnExitCheckBox;
	}
}