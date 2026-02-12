using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFive1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			OnTest(this, new EventArgs());
		}

		private void OnTest(object sender, EventArgs e)
		{
			char[] state = new char[] { 'C', 'A' };
			Person jeffA = new Person("Jeff", "Armstrong", "1752 Grasscreek Drive", "San Dimas", state, "91773");
			Employee stellaB = new Employee("Stella", "Armstrong", "1752 Grasscreek Drive", "San Dimas", state, "91773", 12345);
			Employee adrianA = new Employee("Adrian", "Armstrong", "1752 Grasscreek Drive", "San Dimas", state, "91773", 12345);

			if (stellaB.CompareTo(adrianA) > 0)
				Trace.WriteLine("After");
			else if (stellaB.CompareTo(adrianA) < 0)
				Trace.WriteLine("Before");
			else
				Trace.WriteLine("Equal");
		}
	}
}
