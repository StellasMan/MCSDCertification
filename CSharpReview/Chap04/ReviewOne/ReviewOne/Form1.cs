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

namespace ReviewOne
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			OnTestClicked(this, new EventArgs());
		}

		private void OnTestClicked(object sender, EventArgs e)
		{
			float total = 1234.56f;
			string sTotal = total.ToString("c");
			System.Diagnostics.Trace.WriteLine(sTotal);

			string sSpaces = new string(' ', 10);
			System.Diagnostics.Trace.WriteLine(sSpaces);

			char[] chars = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
			string sSpaces1 = new string(chars);
			Trace.WriteLine(sSpaces1);

			double dblMax = double.MaxValue;
			float flCheck = (float)dblMax;
			if (float.IsInfinity(flCheck) || float.IsNegativeInfinity(flCheck))
				Trace.WriteLine("Infinity");
			else
				Trace.WriteLine(String.Format("{0:f}", flCheck));

			//int big = int.MaxValue;
			//short small = 0;
			// checked
			//{
			//	small = (short)big;
			//}
			//Trace.WriteLine(small);

			float flMin = float.Parse("$1,234.45678", System.Globalization.NumberStyles.Currency);
			Trace.WriteLine(String.Format("{0:C}", flMin));
		}
	}
}
