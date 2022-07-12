using WinFormsMVVMTest1.Models;

namespace WinFormsMVVMTest1
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			// create the form , pass the viewmodel and show it
			Form1 form1 = new()
			{
				PersonVM = new(new Person() { FirstName = "John", LastName = "Doe" })
			};

			Application.Run(form1);
		}
	}
}