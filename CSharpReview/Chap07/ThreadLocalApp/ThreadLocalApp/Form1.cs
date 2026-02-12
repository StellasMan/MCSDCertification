using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLocalApp
{
	public partial class Form1 : Form
	{
		List<Thread> threadList = new List<Thread>();
		private static ThreadLocal<int> _field = new ThreadLocal<int>(() => 10);

		public Form1()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			int nThreads = (int)nudThreads.Value;
			int nStart = (int)nudStartValue.Value;
			int nEnd = (int)nudEndValue.Value;

			RunThreads(nThreads, nStart, nEnd);
		}

		private decimal RunThreads(int nThreads, int nStart, int nEnd)
		{
			decimal decRetVal = 0.0M;

			float flRange = (nEnd - nStart + 1) / (float)nThreads;
			int nPrevRangeStart = nStart - 1;
			threadList.Clear();
			for (int nIx = 1; nIx <= nThreads; nIx++)
			{
				int nRangeStart = nPrevRangeStart + 1;
				int nRangeEnd = (nStart-1) + (int)Math.Round(flRange*nIx);

				Debug.WriteLine($"Thread {nIx}: Start {nRangeStart} {nRangeEnd}");

				ParameterizedThreadStart paramThreadStart = new ParameterizedThreadStart(CalcValuesThread);
				Thread thrdItem = new Thread(paramThreadStart);
				thrdItem.Name = String.Format("Thread {0}", nIx);
				threadList.Add(thrdItem);
				thrdItem.Start(new Object[] { nRangeStart, nRangeEnd });

				nPrevRangeStart = nRangeEnd;
			}
			return decRetVal;
		}

		private void CalcValuesThread(Object objArg)
		{
			Thread current = Thread.CurrentThread;

			_field.Value++; // Only increments THIS thread's copy
			Console.WriteLine($"Thread {current.Name}: Value = {_field.Value}");

			double dblResult = 0f;
			Object[] objValues = (Object[])objArg;
			int nStart = (int)objValues[0];
			int nEnd = (int)objValues[1];

			for (int nIx=nStart; nIx <= nEnd; nIx++)
			{
				dblResult += Math.Pow(nIx, 0.5);
			}

			Trace.WriteLine($"Value for thread '{current.Name}' is {dblResult:F2}");
		}
	}
}
