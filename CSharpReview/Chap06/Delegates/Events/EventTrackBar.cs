using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
	public class EventTrackBarEventArgs : EventArgs
	{
		public EventTrackBarEventArgs(int nSpeed, DateTime dtDateTime) 
		{
			Speed = nSpeed;
			EventTime = dtDateTime;
		}

		public int Speed { get; }
		public DateTime EventTime { get; }
	}

	public class EventTrackBar : TrackBar
	{
		public EventTrackBar()
		{
			this.ValueChanged += new EventHandler(OnValueChanged);
		}

		public void AddSpeedChangedSubscriber(EventHandler<EventTrackBarEventArgs> handler)
		{
			SpeedChangedEvent += handler;
		}

		public void RemoveSpeedChangedSubscriber(EventHandler<EventTrackBarEventArgs> handler)
		{
			SpeedChangedEvent -= handler;
		}

		protected void OnValueChanged(object sender, EventArgs e)
		{
			System.Diagnostics.Trace.WriteLine(String.Format("EventTrackBar.OnValueChanged: {0}", this.Value));
			if (SpeedChangedEvent != null)
			{
				SpeedChangedEvent(this, new EventTrackBarEventArgs(this.Value, DateTime.Now));
			}
		}

		private event EventHandler<EventTrackBarEventArgs> SpeedChangedEvent;
	}
}
