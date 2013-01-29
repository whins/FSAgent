using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sipek.Sip;
using Sipek.Common.CallControl;
using Sipek.Common;
using SIPAgent.Properties;
using System.Security.AccessControl;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Threading;
using WaveLib.AudioMixer;
namespace SIPAgent.SIP
{
	public class Agent : IDisposable
	{
		#region Fields
		private RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\ITSComm\\Agent");
		private ITSCommResources _resources = new ITSCommResources();
		private IStateMachine callState;
		private List<IAccount> AccountsList = new List<IAccount>();
		private EUserStatus _lastUserStatus = EUserStatus.AVAILABLE;
		private Dispatcher _mainDispatcher = Dispatcher.CurrentDispatcher;
		private string dialDigit;
		#endregion Fields

		#region SIP Properties

		public ITSCommResources ITSCommResources
		{
			get { return _resources; }
		}

		public CCallManager CallManager
		{
			get { return _resources.CallManager; }
		}

		public EStateId callStateID
		{
			get { return this.callState.StateId; }
		}

		public bool IsInitialized
		{
			get { return ITSCommResources.StackProxy.IsInitialized; }
		}

		public bool RegisterOnStart
		{
			get { return true; }
		}

		public bool DNDFlag
		{
			get { return ITSCommResources.Configurator.DNDFlag; }
			set 
			{ 
				ITSCommResources.Configurator.DNDFlag = value;
				OnDNDChanged(value);
			}
		}

		public bool AAFlag
		{
			get { return ITSCommResources.Configurator.AAFlag; }
			set 
			{
				ITSCommResources.Configurator.AAFlag = value;
				OnAutoAnswerChanged(value);
			}
		}

		#endregion SIP Properties

		#region Call Operations

		public void MakeCall(string number)
		{
			callState = ITSCommResources.CallManager.createOutboundCall(number);
		}

		public void ReleaseCall()
		{
			if (callState != null)
			{
				ITSCommResources.CallManager.onUserRelease(callState.Session);
			}
		}

		public void AnswerCall()
		{
			if (callState != null)
			{
				ITSCommResources.CallManager.onUserAnswer(callState.Session);				
			}
		}

		public void TransferCall(string number)
		{
			ITSCommResources.CallManager.onUserTransfer(callState.Session, number);
		}

		public void HoldCall()
		{
			ITSCommResources.CallManager.onUserHoldRetrieve(callState.Session);
		}

		public void DialDigitCall(string number)
		{
			ITSCommResources.CallManager.onUserDialDigit(callState.Session, dialDigit, EDtmfMode.DM_Outband);
		}

		public void SetSoundDevice(string PlaybackDeviceID, string RecordingDeviceID)
		{
			ITSCommResources.StackProxy.setSoundDevice(PlaybackDeviceID, RecordingDeviceID);
		}
		#endregion Call Operations

		public void RegisterAccount()
		{
			SubscribeEvents();
			int s = ITSCommResources.CallManager.Initialize();
			ITSCommResources.Registrar.registerAccounts();
			callState = ITSCommResources.CallManager.getCall(-1);
		}

		public void ShutdownSIP()
		{
			ITSCommResources.CallManager.CallStateRefresh -= CallStateRefresh;
			ITSCommResources.CallManager.IncomingCallNotification -= IncomingCall;
			ITSCommResources.Registrar.AccountStateChanged -= AccountStateChange;
			ITSCommResources.Messenger.MessageReceived -= MessageReceived;
			//SipekResources.Messenger.BuddyStatusChanged -= onBuddyStateChanged;
			ITSCommResources.StackProxy.MessageWaitingIndication -= MessageWaiting;
			ITSCommResources.CallManager.Shutdown();
			OnAccountStateChange(0);
		}

		public void UnregisterAccount()
		{
			ITSCommResources.Registrar.unregisterAccounts();
		}

		private void SubscribeEvents()
		{
			ITSCommResources.CallManager.CallStateRefresh += new DCallStateRefresh(CallStateRefresh);
			ITSCommResources.CallManager.IncomingCallNotification += new DIncomingCallNotification(IncomingCall);
			ITSCommResources.Registrar.AccountStateChanged += new DAccountStateChanged(AccountStateChange);

			ITSCommResources.Messenger.MessageReceived += new DMessageReceived(MessageReceived);
			//SipekResources.Messenger.BuddyStatusChanged += onBuddyStateChanged;
			ITSCommResources.StackProxy.MessageWaitingIndication += new DMessageWaitingNotification(MessageWaiting);
		}

		private void MessageWaiting(int mwi, string text)
		{
			OnMessageWaiting.Invoke(mwi, text);
		}

		private void MessageReceived(string from, string text)
		{
			OnMessageReceived.Invoke(from, text);
		}

		private void AccountStateChange(int accId, int accState)
		{
			OnAccountStateChange.Invoke(accState);
		}

		private void CallStateRefresh(int sessionId)
		{
			callState = ITSCommResources.CallManager.getCall(sessionId);			
			if (EStateId.RELEASED == callState.StateId)
				ReleaseCall();
			if (EStateId.IDLE == callState.StateId)
			{ }
			if (EStateId.NULL == callState.StateId)
			{
				OnAccountStateChange.Invoke(ITSCommResources.Configurator.Accounts[0].RegState);
				if (0 < ITSCommResources.CallManager.getNoCallsInState(EStateId.HOLDING))
				{
					callState = ITSCommResources.CallManager.getCallInState(EStateId.HOLDING);
				}
			}
			OnCallStateRefresh.Invoke(callState.StateId);
		}

		private void IncomingCall(int sessionId, string number, string info)
		{
			callState = ITSCommResources.CallManager.getCall(sessionId);
			OnIncomingCall.Invoke(callStateID, number, info + sessionId);
		}

		#region External Events
		public delegate void DAccountStateChangeHandler(int accState);
		public event DAccountStateChangeHandler OnAccountStateChange;

		public delegate void DCallStateRefreshHandler(EStateId callStateID);
		public event DCallStateRefreshHandler OnCallStateRefresh;

		public delegate void DIncomingCallHandler(EStateId callStateID, string number, string info);
		public event DIncomingCallHandler OnIncomingCall;

		public delegate void DMessageReceivedHandler(string from, string text);
		public event DMessageReceivedHandler OnMessageReceived;

		public delegate void DMessageWaitingHandler(int mwi, string text);
		public event DMessageWaitingHandler OnMessageWaiting;

		public delegate void DDNDChangeHandler(bool value);
		public event DDNDChangeHandler OnDNDChanged;

		public delegate void DAutoAnswerChangeHandler(bool value);
		public event DAutoAnswerChangeHandler OnAutoAnswerChanged;
		#endregion External Events

		public Agent()
		{			
		}

		public void Dispose()
		{
			this.Dispose();
		}
	}
}
