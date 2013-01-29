using System.Media;
using Sipek.Common;
using System.IO;

namespace SIPAgent.SIP
{
	public class CMediaPlayerProxy : IMediaProxyInterface
	{
		SoundPlayer player = new SoundPlayer();

		#region Methods

		public int playTone(ETones toneId)
		{

			Stream snd = SIPAgent.Properties.Resources.congestion;

			switch (toneId)
			{
				case ETones.EToneDial:
					snd = SIPAgent.Properties.Resources.dial;
					break;
				case ETones.EToneCongestion:
					snd = SIPAgent.Properties.Resources.congestion;
					break;
				case ETones.EToneRingback:
					snd = SIPAgent.Properties.Resources.ringback;
					break;
				case ETones.EToneRing:
					snd = SIPAgent.Properties.Resources.ring;
					break;
				default:
					break;
			}

			//player.SoundLocation = fname;
			player.Stream = snd;
			player.Load();
			player.PlayLooping();

			return 1;
		}

		public int stopTone()
		{
			player.Stop();
			return 1;
		}

		#endregion
	}
}
