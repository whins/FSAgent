using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SIPAgent
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//SettingsWindow s = new SettingsWindow();
			new Tray();
			Application.Run();
		}
	}
}
