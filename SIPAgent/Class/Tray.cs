using SIPAgent.Properties;
using SIPAgent.SIP;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SIPAgent
{
	internal class Tray
	{
		#region Fields

		private System.ComponentModel.BackgroundWorker SocketWorker;
		private NotifyIcon notifyIcon;
		private static Listener Listener;
		public static Agent Agent;
		private SettingsWindow SettingWindow;

		private Dispatcher dispatcher = Dispatcher.CurrentDispatcher;

		#endregion Fields

		#region Properties

		public Icon Icon
		{
			get { return notifyIcon.Icon; }
			set { notifyIcon.Icon = value; }
		}

		#endregion Properties

		public Tray()
		{
			Initialize();			
			SocketWorker.RunWorkerAsync();
		}

		public void Initialize()
		{		
			InitializeNotifyIcon();
			InitializeAgent();
			SettingWindow = new SettingsWindow(Agent);
			InitializeListener();
		}

		#region InitializeListener

		public void InitializeListener()
		{
			SocketWorker = new System.ComponentModel.BackgroundWorker();
			SocketWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SocketWorker_DoWork);
			Listener = new Listener();
			Listener.OnReceiveCommand += Listener_OnReceiveCommand;
		}

		private void SocketWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Listener.Start();
		}

		private void Listener_OnReceiveCommand(string message)
		{
			if("answer" == message && Agent.callStateID == Sipek.Common.EStateId.INCOMING)
				dispatcher.BeginInvoke(DispatcherPriority.Normal, new ThreadStart(delegate()
				{
					Agent.AnswerCall();
				}));					
			if ("hold" == message && (Agent.callStateID == Sipek.Common.EStateId.ACTIVE || Agent.callStateID == Sipek.Common.EStateId.HOLDING))
				Agent.HoldCall();
		}
		
		#endregion InitializeListener

		#region InitializeAgent

		public void InitializeAgent()
		{
			Agent = new Agent();
			Agent.OnAccountStateChange += Agent_OnAccountStateChange;
			Agent.OnCallStateRefresh += Agent_OnCallStateRefresh;
			Agent.OnIncomingCall += Agent_OnIncomingCall;
			Agent.OnMessageReceived += Agent_OnMessageReceived;
			Agent.OnMessageWaiting += Agent_OnMessageWaiting;
			Agent.OnDNDChanged += Agent_OnDNDChanged;
			Agent.OnAutoAnswerChanged += Agent_OnAutoAnswerChanged;
			Agent.RegisterAccount();
		}

		void Agent_OnAutoAnswerChanged(bool value)
		{
			if (value)
				Icon = Resources.Circle_Orange;
			else
				Icon = Resources.Circle_Green;
		}

		void Agent_OnDNDChanged(bool value)
		{
			if (value)
				Icon = Resources.Circle_Yellow;
			else
				Icon = Resources.Circle_Green;
		}

		void Agent_OnMessageWaiting(int mwi, string text)
		{
			//notifyIcon.ShowBalloonTip(1, mwi.ToString(), text, ToolTipIcon.Info);
		}

		void Agent_OnMessageReceived(string from, string text)
		{
			//notifyIcon.ShowBalloonTip(1, from, text, ToolTipIcon.Info);
		}

		private void Agent_OnIncomingCall(Sipek.Common.EStateId callStateID, string number, string info)
		{
			SetIconByCallStateID(callStateID);
		}

		private void Agent_OnCallStateRefresh(Sipek.Common.EStateId callStateID)
		{
			SetIconByCallStateID(callStateID);
			ShowBalloonTips(callStateID);
		}

		private void ShowBalloonTips(Sipek.Common.EStateId callStateID)
		{
			switch (callStateID)
			{
				case Sipek.Common.EStateId.ACTIVE:
					notifyIcon.ShowBalloonTip(5, "Разговор", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.ALERTING:
					notifyIcon.ShowBalloonTip(2, "Вызов!", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.CONNECTING:
					notifyIcon.ShowBalloonTip(2, "Подключение...", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.HOLDING:
					notifyIcon.ShowBalloonTip(10, "Удержание...", "Состояние звонка", ToolTipIcon.Warning);
					break;
				case Sipek.Common.EStateId.IDLE:
					notifyIcon.ShowBalloonTip(2, "Линия свободна...", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.INCOMING:
					notifyIcon.ShowBalloonTip(2, "Входящий звонок!", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.NULL:
					break;
				case Sipek.Common.EStateId.RELEASED:
					notifyIcon.ShowBalloonTip(1, "Звонок завершен!", "Состояние звонка", ToolTipIcon.Info);
					break;
				case Sipek.Common.EStateId.TERMINATED:
					notifyIcon.ShowBalloonTip(1, "Звонок завершен", "Состояние звонка", ToolTipIcon.Warning);
					break;
			}
		}

		private void SetIconByCallStateID(Sipek.Common.EStateId callStateID)
		{
			switch (callStateID)
			{
				case Sipek.Common.EStateId.ACTIVE:
					Icon = Resources.Circle_Red;
					break;

				case Sipek.Common.EStateId.ALERTING:
					Icon = Resources.Circle_Orange;
					break;

				case Sipek.Common.EStateId.CONNECTING:
					Icon = Resources.Circle_Yellow;
					break;

				case Sipek.Common.EStateId.HOLDING:
					Icon = Resources.Circle_Blue;
					break;

				case Sipek.Common.EStateId.IDLE:
					Icon = Resources.Circle_Yellow;
					break;

				case Sipek.Common.EStateId.INCOMING:
					Icon = Resources.Circle_Orange;
					break;

				case Sipek.Common.EStateId.NULL:
					Icon = Resources.Circle_Green;
					break;

				case Sipek.Common.EStateId.RELEASED:
					Icon = Resources.Circle_Yellow;
					break;

				case Sipek.Common.EStateId.TERMINATED:
					Icon = Resources.Circle_Yellow;
					break;
			}
		}

		private void Agent_OnAccountStateChange(int accState)
		{
			switch (accState)
			{
				case 200:
					Icon = Resources.Circle_Green;
					break;

				case 0:
					Icon = Resources.Circle_Grey;
					break;

				default:
					Icon = Resources.Circle_Yellow;
					break;
			}
		}

		#endregion InitializeAgent

		#region InitializeNotifyIcon

		public void InitializeNotifyIcon()
		{
			notifyIcon = new NotifyIcon();
			notifyIcon.ContextMenu = new ContextMenu();
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Тестовый звонок :: " + Settings.Default.TestNumber, new EventHandler(TestCallItem_onClick)));
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Перезапустить SIP", new EventHandler(ReloadSIPItem_onClick)));
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Настройки", new EventHandler(SettingsItem_onClick)));
			notifyIcon.ContextMenu.MenuItems.Add(new MenuItem("Выход", new EventHandler(ExitItem_onClick)));
			notifyIcon.MouseClick += notifyIcon_MouseClick;
			notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;

			notifyIcon.Visible = true;
			notifyIcon.Icon = Resources.Circle_Grey;
		}

		private void ReloadSIPItem_onClick(object sender, EventArgs e)
		{
			Agent.ShutdownSIP();
			Agent.RegisterAccount();
		}

		private void TestCallItem_onClick(object sender, EventArgs e)
		{
			Agent.MakeCall(Settings.Default.TestNumber);
		}

		private void SettingsItem_onClick(object sender, EventArgs e)
		{
			SettingWindow.Show();
		}

		private void ExitItem_onClick(object sender, EventArgs e)
		{
			Icon = Resources.Circle_Grey;
			Agent.ShutdownSIP();
			notifyIcon.Visible = false;
			Environment.Exit(0);
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Right:
					break;
				case MouseButtons.Middle:
					if (Agent.callStateID == Sipek.Common.EStateId.ACTIVE)
						Agent.HoldCall();
					if (Agent.callStateID == Sipek.Common.EStateId.HOLDING)
						Agent.HoldCall();
					break;
			} 
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			dispatcher.BeginInvoke(DispatcherPriority.Normal, new ThreadStart(delegate()
				{
					
				}));
			switch (Agent.callStateID)
			{
				case Sipek.Common.EStateId.ACTIVE: Agent.ReleaseCall();
					break;
				case Sipek.Common.EStateId.ALERTING: Agent.ReleaseCall();
					break;
				case Sipek.Common.EStateId.INCOMING: Agent.AnswerCall();
					break;
			}
		}

		#endregion InitializeNotifyIcon
	}
}