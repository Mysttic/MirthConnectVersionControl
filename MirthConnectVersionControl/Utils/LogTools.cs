using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirthConnectVersionControl.Utils
{
	public static class LogTools
	{
		/// <summary>
		/// Log a message
		/// </summary>
		/// <param name="form"></param>
		/// <param name="message"></param>
		/// <param name="checkBox"></param>
		/// <param name="cancel"></param>
		/// <param name="caller"></param>
		public static void Log(MainForm form, string message, CheckBox checkBox = null, bool cancel = false, [CallerMemberName] string caller = "")
		{
			string logMessage = DateTime.Now + $"({caller}) - " + message;
			form.Invoke((MethodInvoker)delegate
			{
				form.LogsListBox.Items.Add(logMessage);
				if (cancel && checkBox != null)
					checkBox.Checked = false;
			});
			Task.Run(async () => await File.AppendAllTextAsync(Properties.Settings.Default.LogPath+"\\"+$"logs.txt", logMessage + "\n"));

		}
	}
}
