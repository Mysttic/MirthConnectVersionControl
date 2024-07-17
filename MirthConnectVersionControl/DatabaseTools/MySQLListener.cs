using MirthConnectVersionControl.DTO;
using MirthConnectVersionControl.Utils;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace MirthConnectVersionControl.DatabaseTools
{
	internal class MySQLListener : IDatabaseListener
	{
		private MainForm form;
		MySqlConnection connection;

		public MySQLListener(MainForm _form)
		{
			form = _form;
		}

		/// <summary>
		/// Start the listener
		/// </summary>
		public void Start()
		{
			LogTools.Log(form, $"Listener starting.", caller: GetType().Name);
			try
			{
				Task.Run(() => Listener(Properties.DbSettings.Default.MySQL))
					.ContinueWith(task =>
					{
						if (task.Exception != null)
						{
							Console.WriteLine(task.Exception.GetBaseException().Message);
							LogTools.Log(form, $"Error in task: {task.Exception.GetBaseException().Message}", form.checkBoxMySQL, true, GetType().Name);
						}
					});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				LogTools.Log(form, $"Error starting listener: {ex.Message}", form.checkBoxMySQL, true, GetType().Name);
			}
		}

		/// <summary>
		/// Stop the listener
		/// </summary>
		public void Stop()
		{
			LogTools.Log(form, $"Listener stoped.", caller: GetType().Name);
		}

		/// <summary>
		/// Listen to the database
		/// </summary>
		/// <param name="connectionString"></param>
		/// <returns></returns>
		public async Task Listener(string connectionString)
		{
			try
			{
				using (connection = new MySqlConnection(connectionString))
				{
					await connection.OpenAsync();
					LogTools.Log(form, "Connected to the database.", caller: GetType().Name);

					string sqlCommandText = "SELECT * FROM CHANNEL";

					using (MySqlCommand command = new MySqlCommand(sqlCommandText, connection))
					{
						Dictionary<string, string> channels = new Dictionary<string, string>();
						while (form.checkBoxMySQL.Checked)
						{
							try
							{
								using (DbDataReader reader = await command.ExecuteReaderAsync())
								{
									while (await reader.ReadAsync())
									{
										using (DbDataReaderDto readerDto = new DbDataReaderDto(reader))
										{
											if (!channels.TryGetValue(readerDto.Id, out string? value))
											{
												channels.Add(readerDto.Id, readerDto.Revision);
												GitTools.GitChange(form, reader, GetType().Name);
											}
											else if (value != readerDto.Revision)
											{
												GitTools.GitChange(form, reader, GetType().Name);
												break;
											}
										}
									}
								}
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
								LogTools.Log(form, ex.Message, form.checkBoxMySQL, true, GetType().Name);
							}

							// Wait for a while before querying again
							await Task.Delay(5000); // 5 seconds
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				LogTools.Log(form, $"Error during connection: {ex.Message}", form.checkBoxMySQL, true, GetType().Name);
			}
			finally
			{
				connection?.Close();
			}
		}
	}
}

