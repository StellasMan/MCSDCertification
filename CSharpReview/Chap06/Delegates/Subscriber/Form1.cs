using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subscriber
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			eventCounter = new System.EventHandler(EventTest);

			// Create a timer with a two second interval.
			m_timer = new System.Timers.Timer(2000);

			// Hook up the Elapsed event for the timer. 
			m_timer.Elapsed += OnTimerEvent;
			m_timer.AutoReset = true;
			m_timer.Enabled = true;
		}

		private void EventTest(object sender, EventArgs e)
		{
			m_nCount++;
		}

		private void OnSubscribe(Object sender, EventArgs e)
		{
			eventTest += eventCounter;
		}

		private void OnUnsubscribe(object sender, EventArgs e)
		{
			eventTest -= eventCounter;
		}

		private void OnTimerEvent(object sender, EventArgs e)
		{
			m_nCount = 0;

			if (eventTest != null)
			{
				eventTest(sender, e);
			}

			String sValue = m_nCount.ToString();
			int nRand = rnd.Next(1, 5);
			if (txtCount.InvokeRequired)
			{
				txtCount.Invoke
				(
					new Action<String, int>
					(
						(s, n) => txtCount.Text = s + String.Format(" ({0})", n)
					),
					sValue,
					nRand
				);
			}
			else
			{
				txtCount.Text = sValue + String.Format(" ({0})", nRand);
			}
		}

		Random rnd = new Random(100);
		private System.Timers.Timer m_timer;
		private int m_nCount = 0;
		private event EventHandler eventTest;
		private event EventHandler eventCounter;
	}
}
