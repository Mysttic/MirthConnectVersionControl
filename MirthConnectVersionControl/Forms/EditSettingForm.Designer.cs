namespace MirthConnectVersionControl
{
	partial class EditSettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettingForm));
			SaveButton = new Button();
			label1 = new Label();
			ConnectionStringTextBox = new TextBox();
			panel1 = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// SaveButton
			// 
			SaveButton.Dock = DockStyle.Bottom;
			SaveButton.Location = new Point(10, 122);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(664, 29);
			SaveButton.TabIndex = 2;
			SaveButton.Text = "Save";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(10, 10);
			label1.Name = "label1";
			label1.Size = new Size(103, 15);
			label1.TabIndex = 0;
			label1.Text = "ConnectionString:";
			// 
			// ConnectionStringTextBox
			// 
			ConnectionStringTextBox.Dock = DockStyle.Fill;
			ConnectionStringTextBox.Location = new Point(0, 0);
			ConnectionStringTextBox.Multiline = true;
			ConnectionStringTextBox.Name = "ConnectionStringTextBox";
			ConnectionStringTextBox.Size = new Size(664, 52);
			ConnectionStringTextBox.TabIndex = 3;
			ConnectionStringTextBox.TextChanged += ConnectionStringTextBox_TextChanged;
			ConnectionStringTextBox.KeyPress += ConnectionStringTextBox_KeyPress;
			// 
			// panel1
			// 
			panel1.Controls.Add(ConnectionStringTextBox);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(10, 25);
			panel1.Name = "panel1";
			panel1.Size = new Size(664, 52);
			panel1.TabIndex = 4;
			// 
			// EditSettingForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(684, 161);
			Controls.Add(panel1);
			Controls.Add(label1);
			Controls.Add(SaveButton);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(250, 200);
			Name = "EditSettingForm";
			Padding = new Padding(10);
			StartPosition = FormStartPosition.CenterParent;
			Text = "Edit Setting";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button SaveButton;
		private Label label1;
		private TextBox ConnectionStringTextBox;
		private Panel panel1;
	}
}