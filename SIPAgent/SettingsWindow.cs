using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sipek.Sip;
using Sipek.Common.CallControl;
using Sipek.Common;
using SIPAgent.Properties;
using System.Security.AccessControl;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Threading;
using WaveLib.AudioMixer;
using SIPAgent.SIP;

namespace SIPAgent
{
	public partial class SettingsWindow : Form
	{

		#region Fields
		private Mixers mMixers;
		int _lastMicVolume;
		private Agent _agent;
		#endregion Fields
		


		private void InitializeMixer()
		{
			try
			{
				mMixers = new Mixers();
				mMixers.Playback.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);
				mMixers.Recording.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);
				LoadDeviceCombos(mMixers);
			}
			catch (Exception ex)
			{
				
			}		
		}

		private void LoadDeviceCombos(Mixers mixers)
		{
			//Load Output Combo
			MixerDetail mixerDetailDefault = new MixerDetail();
			mixerDetailDefault.DeviceId = -1;
			mixerDetailDefault.MixerName = "Default";
			mixerDetailDefault.SupportWaveOut = true;
			comboBoxPlaybackDevices.Items.Add(mixerDetailDefault);
			foreach (MixerDetail mixerDetail in mixers.Playback.Devices)
			{
				comboBoxPlaybackDevices.Items.Add(mixerDetail);
			}
			comboBoxPlaybackDevices.SelectedIndex = Settings.Default.SelectedPlaybackDevice;

			//Load Ring Combo
			mixerDetailDefault = new MixerDetail();
			mixerDetailDefault.DeviceId = -1;
			mixerDetailDefault.MixerName = "Default";
			mixerDetailDefault.SupportWaveOut = true;
			comboBoxRingDevices.Items.Add(mixerDetailDefault);
			foreach (MixerDetail mixerDetail in mixers.Playback.Devices)
			{
				comboBoxRingDevices.Items.Add(mixerDetail);
			}
			comboBoxRingDevices.SelectedIndex = Settings.Default.SelectedRingDevice;

			//Load Input Combo
			mixerDetailDefault = new MixerDetail();
			mixerDetailDefault.DeviceId = -1;
			mixerDetailDefault.MixerName = "Default";
			mixerDetailDefault.SupportWaveIn = true;
			comboBoxRecordingDevices.Items.Add(mixerDetailDefault);
			foreach (MixerDetail mixerDetail in mixers.Recording.Devices)
			{
				comboBoxRecordingDevices.Items.Add(mixerDetail);
			}
			comboBoxRecordingDevices.SelectedIndex = Settings.Default.SelectedRecordingDevice;
		}

		private void mMixer_MixerLineChanged(Mixer mixer, MixerLine line)
		{
			//mAvoidEvents = true;
		}

		private void checkBoxPlaybackMute_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox chkBox = (CheckBox)sender;
			MixerLine line = (MixerLine)chkBox.Tag;
			if (line.Direction == MixerType.Recording)
			{
				line.Channel = Channel.Uniform;
				if (checkBoxRecordingMute.Checked == true)
				{
					_lastMicVolume = line.Volume;
					line.Volume = 0;
				}
				else
				{
					line.Volume = _lastMicVolume;
				}
			}
			if (line.ContainsMute) line.Mute = chkBox.Checked;
		}

		public SettingsWindow(Agent agent)
		{
			_agent = agent;
			InitializeComponent();
			InilializeSIP();

			InitializeMixer();
		}

		public void InilializeSIP()
		{
			checkBoxAAFlag.Checked = _agent.AAFlag;
			checkBoxDNDFlag.Checked = _agent.DNDFlag;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
			_agent.SetSoundDevice(mMixers.Playback.DeviceDetail.MixerName, mMixers.Recording.DeviceDetail.MixerName);
			this.Hide();
		}

		private void comboBoxPlaybackDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.SelectedPlaybackDevice = ((System.Windows.Forms.ComboBox)(sender)).SelectedIndex;
			LoadValues((ComboBox)sender);
		}

		private void comboBoxRingDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.SelectedRingDevice = ((System.Windows.Forms.ComboBox)(sender)).SelectedIndex;
			LoadValues((ComboBox)sender);
		}

		private void comboBoxRecordingDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.SelectedRecordingDevice = ((System.Windows.Forms.ComboBox)(sender)).SelectedIndex;
			LoadValues((ComboBox)sender);
		}

		private void LoadValues(ComboBox  comboBox)
		{
			return;
			MixerLine line;

			if (comboBoxPlaybackDevices == comboBox)
			{
				mMixers.Playback.DeviceId = ((MixerDetail)comboBox.SelectedItem).DeviceId;
				line = mMixers.Playback.UserLines.GetMixerFirstLineByComponentType(MIXERLINE_COMPONENTTYPE.DST_SPEAKERS);
			}			
		}

		private void checkBoxAAFlag_CheckedChanged(object sender, EventArgs e)
		{
			_agent.AAFlag = checkBoxAAFlag.Checked;
		}

		private void checkBoxDNDFlag_CheckedChanged(object sender, EventArgs e)
		{
			_agent.DNDFlag = checkBoxDNDFlag.Checked;
		}
	}
}
