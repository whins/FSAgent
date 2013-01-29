using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSAgent
{
	public enum CALL_STATE
	{
		ACTIVE,
		ALERTING,
		CONNECTING,
		HOLDING,
		IDLE,
		INCOMING,
		NULL,
		RELEASED,
		TERMINATED,
		None, Answered, Ringing, Ended, Busy, Failed, Missed, Hold, Hold_Ringing
	}
}
