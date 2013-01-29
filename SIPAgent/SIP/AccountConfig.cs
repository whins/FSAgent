using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using Microsoft.Win32;
using Sipek.Common;
using SIPAgent.Properties;

namespace SIPAgent.SIP
{
	public class AccountConfig : IAccount
	{
		private RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\ITSComm\\Account");

		#region Constructor
		public AccountConfig()
		{
			regKey.SetAccessControl(new RegistrySecurity());
		}
		#endregion

		#region Account Properties

		public bool Enabled
		{
			get
			{
				return Settings.Default.cfgAccountEnabled;
			}
			set
			{
				Settings.Default.cfgAccountEnabled = value;
			}
		}


		public int Index
		{
			get
			{
				return Settings.Default.cfgAccountIndex;
			}
			set
			{
				Settings.Default.cfgAccountIndex = value;
			}
		}

		public string AccountName
		{
			get
			{
				return Settings.Default.cfgAccountName;

			}
			set
			{
				Settings.Default.cfgAccountName = value;
			}
		}

		public string HostName
		{
			get
			{
				return Settings.Default.cfgAccountAddress;
			}
			set
			{
				Settings.Default.cfgAccountAddress = value;
			}
		}

		public string Id
		{
			get
			{
				return Settings.Default.cfgAccountID;
			}
			set
			{
				Settings.Default.cfgAccountID = value;
			}
		}

		public string UserName
		{
			get
			{
				return Settings.Default.cfgAccountUsername;
			}
			set
			{
				Settings.Default.cfgAccountUsername = value;
			}
		}

		public string Password
		{
			get
			{
				return Settings.Default.cfgAccountPassword;
			}
			set
			{
				Settings.Default.cfgAccountPassword = value;
			}
		}

		public string DisplayName
		{
			get
			{
				return Settings.Default.cfgAccountDisplayName;
			}
			set
			{
				Settings.Default.cfgAccountDisplayName = value;
			}
		}

		public string DomainName
		{
			get
			{
				return Settings.Default.cfgAccountDomain;
			}
			set
			{
				Settings.Default.cfgAccountDomain = value;
			}
		}

		public int RegState
		{
			get
			{
				return Settings.Default.cfgAccountState;
			}
			set
			{
				Settings.Default.cfgAccountState = value;
			}
		}

		public string ProxyAddress
		{
			get
			{
				return Settings.Default.cfgAccountProxyAddress;
			}
			set
			{
				Settings.Default.cfgAccountProxyAddress = value;
			}
		}

		public ETransportMode TransportMode
		{
			get
			{
				return (ETransportMode)Settings.Default.cfgAccountTransport;
			}
			set
			{
				Settings.Default.cfgAccountTransport = (int)value;
			}
		}
		#endregion Account Properties
			
	}
}
