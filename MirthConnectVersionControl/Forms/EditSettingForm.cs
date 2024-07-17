using MirthConnectVersionControl.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirthConnectVersionControl
{
	public partial class EditSettingForm : Form
	{
		public EditSettingForm(string name, string setting)
		{
			InitializeComponent();
			this.Text = name;
			ConnectionStringTextBox.Text = setting;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Properties.DbSettings.Default[this.Text] = ConnectionStringTextBox.Text;
			Properties.DbSettings.Default.Save();
			this.Close();
		}

		private void ConnectionStringTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
			}
		}

		private void ConnectionStringTextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				string text = textBox.Text;
				text = text.Replace(Environment.NewLine, " ").Replace("\n", " ").Replace("\r", " ");
				textBox.Text = text;
			}
		}
	}
}
