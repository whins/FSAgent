using System;
using System.Windows.Forms;
using FreeSWITCH.Native;
using FSAgent.Properties;
using System.Collections.Generic;
using System.Linq;

namespace FSAgent
{
	public partial class AgentForm : Form
	{
		private class InternalAudioDevice
		{
			public AudioDevice device;
			public int id;
			public bool is_alive;
		}
		private static List<InternalAudioDevice> _devices = new List<InternalAudioDevice>();

		private static AudioDevice[] _pub_devices;

		public class AudioDevice
		{
			public readonly string name;
			public readonly int inputs;
			public readonly int outputs;
			public readonly int guid;
			public AudioDevice(int guid, string name, int inputs, int outputs)
			{
				this.name = name;
				this.guid = guid;
				this.inputs = inputs;
				this.outputs = outputs;
			}
			public override string ToString()
			{
				return name;
			}
			public void SetInputDevice()
			{
				FSAgent.AgentForm.SetInputDevice(guid);
			}
			public void SetOutputDevice()
			{
				FSAgent.AgentForm.SetOutputDevice(guid);
			}
			public void SetRingDevice()
			{
				FSAgent.AgentForm.SetRingDevice(guid);
			}
		}

		public static void SetInputDevice(int guid)
		{
			api_exec("pa", "indev #" + guid_to_id(guid));
		}
		public static void SetOutputDevice(int guid)
		{
			api_exec("pa", "outdev #" + guid_to_id(guid));

		}
		public static void SetRingDevice(int guid)
		{
			api_exec("pa", "ringdev #" + guid_to_id(guid));
		}

		private static int guid_to_id(int guid)
		{
			return (from I in _devices where I.device.guid == guid select I.id).FirstOrDefault();
		}

		#region Fields

		private string number = "1007";
		private String sip_server = "10.10.10.111";
		private String sip_port = "5060";
		private String sip_user = "1010";
		private String sip_password = "1234";

		private static Api API;
		private IDisposable search_bind;
		private IDisposable event_bind;

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
		
		public void InitializeFS(String FS_Server, String FS_Port, String FS_UserName, String FS_Password)
		{
			sip_server = FS_Server;
			sip_port = FS_Port;
			sip_user = FS_UserName;
			sip_password = FS_Password;
		}

		public static string api_exec(String cmd, String args)
		{
			if (API == null)
				API = new Api();
			return API.Execute(cmd, args);
		}

		private void fs_core_end()
		{
			freeswitch.switch_core_destroy();
		}

		private void fs_core_init()
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
			if (switchEvent.event_id == switch_event_types_t.SWITCH_EVENT_MODULE_LOAD)
				return;

			if (switchEvent.event_id == switch_event_types_t.SWITCH_EVENT_CUSTOM && switchEvent.subclass_name == "sofia::gateway_state")
				eventString = "Sofia Gateway State: " + freeswitch.switch_event_get_header_ptr(switchEvent, "State");
			else
				eventString = "Event " + switchEvent.subclass_name;
			eventString = switchEvent.event_id + " ^^ " + switchEvent.subclass_name + " ^^ " + switchEvent.body;
			if (switchEvent.event_id == switch_event_types_t.SWITCH_EVENT_CUSTOM && switchEvent.subclass_name == "portaudio::ringing")
			{
			}
			this.BeginInvoke(new DRefreshTEXT(this.RefreshTEXT));
		}


		delegate void DRefreshTEXT();
		private void RefreshTEXT()
		{
			textBox1.AppendText(eventString + Environment.NewLine);

		}

		public void MakeCall(string number)
		{
			var s = api_exec("pa", "call sofia/gateway/1/" + number);
		}

		#region Events

		private delegate void DSofiaEventHandler(switch_event evt);
		private event DSofiaEventHandler OnSofiaEvent;
		private void event_handler(FreeSWITCH.EventBinding.EventBindingArgs args)
		{
			OnSofiaEvent(args.EventObj);
		}

		#endregion
		
		public AgentForm()
		{			
			InitializeComponent();
			OnSofiaEvent = new DSofiaEventHandler(actual_event_handler);			
		}

		private void load_devices(bool from_settings)
		{
			var s = api_exec("pa", "rescan");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var s = api_exec("pa", "call sofia/gateway/1/" + number);
		}

		private void AgentForm_Load(object sender, EventArgs e)
		{
			fs_core_init();
			this.notifyIcon.Icon = Resources.Circle_Blue;
			this.notifyIcon.Visible = true;
			load_devices(true);
		}

		private void AgentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void ToolStripMenuItemProperties_Click(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				this.Hide();
			}
			else
			{
				this.Show();
			}

		}

		private void Agent_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
			this.notifyIcon.Visible = false;
			fs_core_end();			
		}

		private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			api_exec("pa", "hangup");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			api_exec("pa", "answer");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			fs_core_init();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			fs_core_end();
		}
	}

	

}
