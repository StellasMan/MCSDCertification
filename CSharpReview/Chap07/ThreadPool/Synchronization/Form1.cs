using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synchronization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int nIx = 1; nIx <= 4; nIx++)
			{
				Object objCount = nIx;
				double result = 0;
				Int32 nValue = nIx;
				Thread myThread = new Thread(() => result = RunTask(nValue));
				myThread.IsBackground = true;
				myThread.Priority = ThreadPriority.BelowNormal;
				m_aThreads[nIx-1] = myThread;
				myThread.Start();
			}
		}

		private double RunTask(int nThreadNo)
		{
			TextBox textBox =	(nThreadNo == 1) ? txtThread1 :
								(nThreadNo == 2) ? txtThread2 :
								(nThreadNo == 3) ? txtThread3 : txtThread4;

			System.Diagnostics.Trace.WriteLine(String.Format($"Starting thread {nThreadNo}"));

			Action<TextBox, String> textUpdateDelegate = (tb, sVal) => tb.Text = sVal;

			while (!m_bCancelled)
			{
				m_aWaitHandle.WaitOne();
				m_anValues[nThreadNo-1]++;
				String sValue = m_anValues[nThreadNo - 1].ToString();

				// textBox.Invoke(textUpdateDelegate, textBox, sValue);
				textBox.Invoke(new Action<TextBox, String>((tb, s) => tb.Text = s), textBox, sValue);

				int nTotal = m_anValues.Sum();
				txtTotal.Invoke(textUpdateDelegate, txtTotal, nTotal.ToString());
			}

			System.Diagnostics.Trace.WriteLine(String.Format($"Thread {nThreadNo} ending"));

			return 0d;
		}

		private void OnRelease(object sender, EventArgs e)
		{
			m_aWaitHandle.Set();
		}

		private void OnCancel(object sender, EventArgs e)
		{
			m_bCancelled = true;
		}

		int[] m_anValues = { 0, 0, 0, 0 };
		bool m_bCancelled = false;
		EventWaitHandle m_aWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
		Thread[] m_aThreads = new Thread[4];
	}
}
