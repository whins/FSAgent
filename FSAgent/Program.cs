using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FSAgent.Properties;

namespace FSAgent
{
	static class Program
	{

		static NotifyIcon i;
		static AgentForm form;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run( new AgentForm());
			Tray trey = new Tray();

			
			Application.Run();
		}
	}
}
