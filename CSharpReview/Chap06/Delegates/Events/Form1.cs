using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
	public partial class EventForm : Form
	{
		public EventForm()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			m_Event += (x, y) => MessageBox.Show(String.Format("Event fired: x={0}, y={1}", x, y));
		}

		private void OnAddEventHandler(object sender, EventArgs e)
		{
			m_scSpeedometer.AddSpeedChangedSubscriber(m_trkbarGasPedal);
		}

		private delegate void MyDelegate(float x, int y);
		private MyDelegate m_Delegate = (x, y) =>
		{
			if (x > 0)
			{
				MessageBox.Show(x.ToString());
			}
			else
			{
				MessageBox.Show("x is less than or equal to 0");
				y++;
			}
		};

		private event MyDelegate m_Event;
	}
}
