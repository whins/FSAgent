using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Windows.Threading;
using System.Security.AccessControl;
using Microsoft.Win32;
using FSAgent.Properties;

namespace FSAgent
{
	public class Tray : IDisposable
	{
		private System.ComponentModel.BackgroundWorker SocketWorker;
		private System.ComponentModel.BackgroundWorker AgentWorker;

		NotifyIcon notifyIcon;

		private static Listener Listener;
		private static Agent Agent;

		private Dispatcher dispatcher = Dispatcher.CurrentDispatcher;

		public Tray()
		{
			Initialize();
			SocketWorker.RunWorkerAsync();
			if (Settings.Default.start_with_credentials)
			{
				AgentWorker.RunWorkerAsync();
			}
		}

		#region NotifyIcon

		public void InitializeNotifyIcon()
		{
			notifyIcon = new NotifyIcon();
			notifyIcon.ContextMenu = new ContextMenu();
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Настройки", new EventHandler(SettingsItem_onClick)));
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("1020", new EventHandler(Call2Item_onClick)));
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Выход", new EventHandler(ExitItem_onClick)));
			
			notifyIcon.MouseClick += new MouseEventHandler(Tray_MouseClick);
			notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;

			notifyIcon.Visible = true;
			notifyIcon.Icon = Resources.Circle_Grey;
		}

		void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			switch (Agent.CALL_STATE)
			{
				case CALL_STATE.ACTIVE:
				case CALL_STATE.ALERTING: Agent.EndCall();
					break;
				case CALL_STATE.INCOMING: Agent.Answer();
					break;
			}
		}
		private void ExitItem_onClick(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void SettingsItem_onClick(object sender, EventArgs e)
		{
			
		}

		private void Call2Item_onClick(object sender, EventArgs e)
		{
			Agent.Call();
		}

		private static void Tray_MouseClick(object sender, MouseEventArgs e)
		{
			switch(e.Button)
			{
				case MouseButtons.Right:
					break;
				case MouseButtons.Middle:
					break;
			} 
		}

		#endregion NotifyIcon

		public void InitializeAgent()
		{ 
			AgentWorker = new System.ComponentModel.BackgroundWorker();
			AgentWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AgentWorker_DoWork);
			Agent = new Agent();
			Agent.OnCallStateChanged += Agent_OnCallStateChanged;
			Agent.OnAccountStateChanged += Agent_OnAccountStateChanged;
		}

		private void AgentWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Agent.fs_core_init();
		}

		public void Initialize()
		{
			InitializeNotifyIcon();			
			SocketWorker = new System.ComponentModel.BackgroundWorker();
			SocketWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SocketWorker_DoWork);

			Listener = new Listener();
			
			Listener.OnReceiveCommand += Listener_OnReceiveCommand;
			InitializeAgent();
		}

		private void SocketWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Listener.Start();
		}

		private void Listener_OnReceiveCommand(string message)
		{
			CommandProcessing(message);
		}

		private void CommandProcessing(string message)
		{
			string[] command = message.Split(' ');

			switch (command[0])
			{
				case "register": RegisterAccountProcesing(command);
					break;
				case "unregister":
					break;
				case "exit": this.Dispose();
					break;
				case "2":
					break;
				default :
					dispatcher.BeginInvoke(DispatcherPriority.Normal, new ThreadStart(delegate()
					{
						Agent.api_exec("pa", message);
					}));
					break;
			}
		}

		public void RegisterAccountProcesing(string[] crd)
		{
			Settings.Default.sip_server = crd[1];
			Settings.Default.sip_port = crd[2];
			Settings.Default.sip_user = crd[3];
			Settings.Default.sip_password= crd[4];
			Settings.Default.Save();
			if (null == Agent)
			{
				InitializeAgent();				
			}
		}

		private void Agent_OnAccountStateChanged(ACCOUNT_STATE state)
		{
			SetIconByAccountState(state);
		}

		private void Agent_OnCallStateChanged(CALL_STATE state)
		{
			SetIconByCallState(state);
		}

		private void SetIconByCallState(CALL_STATE state)
		{
			switch (state)
			{ 
				case CALL_STATE.ACTIVE:Icon = Resources.Circle_Red;
					break;
				case CALL_STATE.ALERTING:Icon = Resources.Circle_Orange;
					break;
				case CALL_STATE.CONNECTING:Icon = Resources.Circle_Yellow;
					break;
				case CALL_STATE.HOLDING:Icon = Resources.Circle_Blue;
					break;
				case CALL_STATE.IDLE: SetIconByAccountState(Agent.ACCOUNT_STATE);
					break;
				case CALL_STATE.INCOMING:Icon = Resources.Circle_Orange;
					break;
				case CALL_STATE.NULL: SetIconByAccountState(Agent.ACCOUNT_STATE);
					break;
				case CALL_STATE.RELEASED:
					Icon = Resources.Circle_Yellow;
					SetIconByAccountState(Agent.ACCOUNT_STATE);
					break;
				case CALL_STATE.TERMINATED:Icon = Resources.Circle_Yellow;
					break;
			}
			if (Agent.CALL_STATE != CALL_STATE.NULL)
			notifyIcon.ShowBalloonTip(2, state.ToString(), "dfs", ToolTipIcon.Info);
		}

		private void SetIconByAccountState(ACCOUNT_STATE state)
		{
			switch (state)
			{
				case ACCOUNT_STATE.REGISTERED: Icon = Resources.Circle_Green;					
					break;
				case ACCOUNT_STATE.REGISTERING: Icon = Resources.Circle_Yellow;
					break;
				case ACCOUNT_STATE.UNREGISTED: Icon = Resources.Circle_Grey;
					break;
			}
		}

		public Icon Icon
		{
			get { return notifyIcon.Icon; }
			set { notifyIcon.Icon = value; }
		}

		public void Dispose()
		{
			SocketWorker.Dispose();
			Agent.fs_core_end();
			notifyIcon.Visible = false;
			Environment.Exit(0);
		}
	}
}
