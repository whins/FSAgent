using FreeSWITCH.Native;
using FSAgent.Properties;
using System;

namespace FSAgent
{
	public class Agent : IDisposable
	{
		#region Events

		public delegate void DCallStateHandler(CALL_STATE state);

		public event DCallStateHandler OnCallStateChanged;

		public delegate void DAccountStateHandler(ACCOUNT_STATE state);

		public event DAccountStateHandler OnAccountStateChanged;

		private delegate void DSofiaEventHandler(switch_event evt);

		private event DSofiaEventHandler OnSofiaEvent;

		private void event_handler(FreeSWITCH.EventBinding.EventBindingArgs args)
		{
			OnSofiaEvent(args.EventObj);
		}

		#endregion Events

		#region Fields

		private string number = "1007";
		private String sip_server = Settings.Default.sip_server;
		private String sip_port = Settings.Default.sip_port;
		private String sip_user = Settings.Default.sip_user;
		private String sip_password = Settings.Default.sip_password;
		private static Api API;
		private IDisposable search_bind;
		private IDisposable event_bind;
		private static ACCOUNT_STATE account_state;
		private static CALL_STATE call_state;

		private string eventString;

		private const string sofia_config =
			@"<document type='freeswitch/xml'>
				<section name='configuration'>
				<configuration name='sofia.conf' description='Sofia Endpoint'>
					<profiles>
					<profile name='softphone'>
						<gateways>
						<gateway name='1'>
							<param name='realm' value='SIP_SERVER' />
							<param name='username' value='SIP_USERNAME' />
							<param name='password' value='SIP_PASSWORD' />
						</gateway>
						</gateways>
						<settings>
						<param name='context' value='public' />
						<param name='dialplan' value='xml' />
						<param name='codec-prefs' value='PCMA,GSM,PCMU' />
						<param name='inbound-codec-negotiation' value='generous' />
						<param name='sip-port' value='5070' />
						</settings>
					</profile>
					</profiles>
				</configuration>
				</section>
			</document>";

		#endregion Fields

		public void InitializeAccount(String FS_Server, String FS_Port, String FS_UserName, String FS_Password)
		{
			sip_server = FS_Server;
			sip_port = FS_Port;
			sip_user = FS_UserName;
			sip_password = FS_Password;
		}

		public ACCOUNT_STATE ACCOUNT_STATE
		{
			get { return account_state; }
			set
			{
				account_state = value;
				OnAccountStateChanged(account_state);
			}
		}

		public CALL_STATE CALL_STATE
		{
			get { return call_state; }
			set
			{
				call_state = value;
				OnCallStateChanged(call_state);
			}
		}

		public Agent()
		{
			OnSofiaEvent = new DSofiaEventHandler(actual_event_handler);
		}

		public static string api_exec(String cmd, String args)
		{
			if (API == null)
				API = new Api();
			return API.Execute(cmd, args);
		}

		public void fs_core_end()
		{
			ACCOUNT_STATE = ACCOUNT_STATE.UNREGISTED;
			freeswitch.switch_core_destroy();
		}

		public void fs_core_init()
		{
			String err = "";
			const uint flags = (uint)0;// (switch_core_flag_enum_t.SCF_USE_SQL | switch_core_flag_enum_t.SCF_USE_AUTO_NAT);
			freeswitch.switch_core_set_globals();
			/*Next 3 lines only needed if you want to bind to the initial event or xml config search loops */
			freeswitch.switch_core_init(flags, switch_bool_t.SWITCH_FALSE, ref err);
			search_bind = FreeSWITCH.SwitchXmlSearchBinding.Bind(xml_search, switch_xml_section_enum_t.SWITCH_XML_SECTION_CONFIG);
			event_bind = FreeSWITCH.EventBinding.Bind("SampleClient", switch_event_types_t.SWITCH_EVENT_ALL, null, event_handler, true);
			/* End Optional Lines */
			freeswitch.switch_core_init_and_modload(flags, switch_bool_t.SWITCH_FALSE, ref err);
		}

		public void Answer(int call_id)
		{
			api_exec("pa", "answer " + call_id);
		}

		public void Answer()
		{
			api_exec("pa", "answer");
		}

		public void Call()
		{
			api_exec("pa", "call sofia/gateway/1/" + number);
		}

		public void EndCall()
		{
			api_exec("pa", "hangup");
		}

		private string xml_search(FreeSWITCH.SwitchXmlSearchBinding.XmlBindingArgs args)
		{
			if (args.KeyName != "name" || args.Section != "configuration" || args.TagName != "configuration" || args.KeyValue != "sofia.conf")
				return null;
			String config = sofia_config;
			config = config.Replace("SIP_SERVER", sip_server + ":" + sip_port);
			config = config.Replace("SIP_USERNAME", sip_user);
			config = config.Replace("SIP_PASSWORD", sip_password);
			return config;
		}

		private void actual_event_handler(switch_event switchEvent)
		{
			if (CALL_STATE == CALL_STATE.NULL)
				ACCOUNT_STATE = ACCOUNT_STATE.REGISTERED;
			if (switchEvent.event_id == switch_event_types_t.SWITCH_EVENT_MODULE_LOAD)
			{
				CALL_STATE = CALL_STATE.NULL;
				ACCOUNT_STATE = ACCOUNT_STATE.REGISTERING;
				return;
			}

			String uuid = "";//switchEvent.get_header("Unique-ID");
			switch (switchEvent.event_id)
			{
				case switch_event_types_t.SWITCH_EVENT_CHANNEL_CREATE:
					HandleChannelCreateEvent(switchEvent, uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_CHANNEL_OUTGOING:
					HandleOutgoingEvent(switchEvent, uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_CHANNEL_HANGUP_COMPLETE:
					HandleHangupCompleteEvent(switchEvent, uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_CHANNEL_ANSWER:
					HandleChannelAnswerEvent(switchEvent, uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_CUSTOM:
					HandleCustomEvent(switchEvent, uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_CHANNEL_DESTROY:

					//channels.Remove(uuid);
					break;

				case switch_event_types_t.SWITCH_EVENT_DTMF:
					HandleDTMFEvent(switchEvent, uuid);
					break;

				default:

					break;
			}
		}

		private static void HandleDTMFEvent(switch_event evt, string uuid)
		{
		}

		public static void HandleOutgoingEvent(switch_event evt, String uuid) //capture an outgoing call the other leg
		{
		}

		public void HandleHangupCompleteEvent(switch_event evt, String uuid)
		{
			CALL_STATE = CALL_STATE.RELEASED;
		}

		private static void HandleChannelCreateEvent(switch_event evt, string uuid)
		{
		}

		private void HandleCustomEvent(switch_event evt, string uuid)
		{
			if (evt.subclass_name == "portaudio::ringing")
			{
				CALL_STATE = CALL_STATE.INCOMING;
			}
			else if (evt.subclass_name == "portaudio::makecall")
			{
				CALL_STATE = CALL_STATE.ALERTING;
			}
			else if (evt.subclass_name == "portaudio::callheld" || evt.subclass_name == "portaudio::callresumed")
			{
				CALL_STATE = CALL_STATE.HOLDING;
			}
		}

		private void HandleChannelAnswerEvent(switch_event evt, String uuid)
		{
			if (CALL_STATE == CALL_STATE.Answered)
				return;
			CALL_STATE = CALL_STATE.ACTIVE;
		}

		public void Dispose()
		{
			fs_core_end();
		}
	}
}