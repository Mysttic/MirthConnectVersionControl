namespace MirthConnectVersionControl.DatabaseTools
{
	internal interface IDatabaseListener
	{
		/// <summary>
		/// Start the listener
		/// </summary>
		void Start();

		/// <summary>
		///	Stop the listener
		/// </summary>
		void Stop();

		/// <summary>
		/// Listener
		/// </summary>
		/// <param name="connectionString"></param>
		/// <returns></returns>
		Task Listener(string connectionString);
	}
}