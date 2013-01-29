using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using Microsoft.Win32;
using Sipek.Sip;
using Sipek.Common;
using SIPAgent.Properties;

namespace SIPAgent.SIP
{
	public class PhoneConfig : IConfiguratorInterface
	{
		private RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\ITSComm\\Sip");

		#region Constructor
		public PhoneConfig()
		{
			regKey.SetAccessControl(new RegistrySecurity());
		}
		#endregion Constructor

		#region PhoneConfig Properties

		public bool IsNull
		{
			get { return false; }
		}

		public bool CFUFlag
		{
			get { return Settings.Default.cfgCFUFlag; }
			set { Settings.Default.cfgCFUFlag = value; }
		}

		public string CFUNumber
		{
			get { return Settings.Default.cfgCFUNumber; }
			set { Settings.Default.cfgCFUNumber = value; }
		}

		public bool CFNRFlag
		{
			get { return Settings.Default.cfgCFNRFlag; }
			set { Settings.Default.cfgCFNRFlag = value; }
		}

		public string CFNRNumber
		{
			get { return Settings.Default.cfgCFNRNumber; }
			set { Settings.Default.cfgCFNRNumber = value; }
		}

		public bool DNDFlag
		{
			get { return Settings.Default.cfgDNDFlag; }
			set { Settings.Default.cfgDNDFlag = value; }
		}

		public bool AAFlag
		{
			get { return Settings.Default.cfgAAFlag; }
			set { Settings.Default.cfgAAFlag = value; }
		}

		public bool CFBFlag
		{
			get { return Settings.Default.cfgCFBFlag; }
			set { Settings.Default.cfgCFBFlag = value; }
		}

		public string CFBNumber
		{
			get { return Settings.Default.cfgCFBNumber; }
			set { Settings.Default.cfgCFBNumber = value; }
		}

		public int SIPPort
		{
			get { return int.Parse(Settings.Default.cfgSipPort); }
			set { Settings.Default.cfgSipPort = value.ToString(); }
		}

		public bool PublishEnabled
		{
			get
			{
				SipConfigStruct.Instance.publishEnabled = Settings.Default.cfgSipPublishEnabled;
				return Settings.Default.cfgSipPublishEnabled;
			}
			set
			{
				SipConfigStruct.Instance.publishEnabled = value;
				Settings.Default.cfgSipPublishEnabled = value;
			}
		}

		public string StunServerAddress
		{
			get
			{
				SipConfigStruct.Instance.stunServer = Settings.Default.cfgStunServerAddress;
				return Settings.Default.cfgStunServerAddress;
			}
			set
			{
				Settings.Default.cfgStunServerAddress = value;
				SipConfigStruct.Instance.stunServer = value;
			}
		}

		public EDtmfMode DtmfMode
		{
			get
			{
				return (EDtmfMode)Settings.Default.cfgDtmfMode;
			}
			set
			{
				Settings.Default.cfgDtmfMode = (int)value;
			}
		}

		public int Expires
		{
			get
			{
				SipConfigStruct.Instance.expires = Settings.Default.cfgRegistrationTimeout;
				return Settings.Default.cfgRegistrationTimeout;
			}
			set
			{
				Settings.Default.cfgRegistrationTimeout = value;
				SipConfigStruct.Instance.expires = value;
			}
		}

		public int ECTail
		{
			get
			{
				SipConfigStruct.Instance.ECTail = Settings.Default.cfgECTail;
				return Settings.Default.cfgECTail;
			}
			set
			{
				Settings.Default.cfgECTail = value;
				SipConfigStruct.Instance.ECTail = value;
			}
		}

		public bool VADEnabled
		{
			get
			{
				SipConfigStruct.Instance.VADEnabled = Settings.Default.cfgVAD;
				return Settings.Default.cfgVAD;
			}
			set
			{
				Settings.Default.cfgVAD = value;
				SipConfigStruct.Instance.VADEnabled = value;
			}
		}

		public string NameServer
		{
			get
			{
				SipConfigStruct.Instance.nameServer = Settings.Default.cfgNameServer;
				return Settings.Default.cfgNameServer;
			}
			set
			{
				Settings.Default.cfgNameServer = value;
				SipConfigStruct.Instance.nameServer = value;
			}
		}

		public int DefaultAccountIndex
		{
			get
			{
				return Settings.Default.cfgAccountDefault;
			}
			set
			{
				Settings.Default.cfgAccountDefault = value;
			}
		}

		public List<IAccount> Accounts
		{
			get
			{
				List<IAccount> accList = new List<IAccount>();
				for (int i = 0; i < 1; i++)
				{
					AccountConfig item = new AccountConfig();
					accList.Add(item);
				}
				return accList;
			}
		}

		public List<string> CodecList
		{
			get
			{
				List<string> codecList = new List<string>();
				System.Collections.Specialized.StringCollection CodecList = new System.Collections.Specialized.StringCollection();
				//CodecList = Settings.Default.cfgCodecList;
				if (null != Settings.Default.cfgCodecList)
				{
					CodecList = Settings.Default.cfgCodecList;
				}

				foreach (string item in CodecList)
				{
					codecList.Add(item);
				}
				return codecList;
			}
			set
			{
				Settings.Default.cfgCodecList.Clear();
				List<string> cl = value;
				System.Collections.Specialized.StringCollection CodecList = new System.Collections.Specialized.StringCollection();
				foreach (string item in cl)
				{
					CodecList.Add(item);
				}
				Settings.Default.cfgCodecList = CodecList;
			}
		}

		#endregion PhoneConfig Properties
		

		public void Save()
		{
		}

	}
}
