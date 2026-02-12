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
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThreadPool
{
	public partial class Form1 : Form
	{
		enum THREAD_TYPE
		{
			THREAD_TYPE_THREAD,
			THREAD_TYPE_TASK
		}

		class ComboItem
		{
			public string Text;
			public THREAD_TYPE Value;
			public override String ToString()
				{ return Text; }
		}

		public Form1()
		{
			InitializeComponent();

			int nCPThreads;
			System.Threading.ThreadPool.GetMaxThreads(out m_nAvailableThreads, out nCPThreads);
			txtMaxThreads.Text = m_nAvailableThreads.ToString();

			cmbThreadType.Items.Clear();

			cmbThreadType.DisplayMember = "Text";
			cmbThreadType.ValueMember = "Value";

			var itemOne = new ComboItem { Text = "Thread", Value = THREAD_TYPE.THREAD_TYPE_THREAD };
			cmbThreadType.Items.Add(itemOne);

			var itemTwo = new ComboItem { Text = "Task", Value = THREAD_TYPE.THREAD_TYPE_TASK };
			cmbThreadType.Items.Add(itemTwo);

			cmbThreadType.SelectedIndex = 0;

			System.Timers.Timer aTimer = new System.Timers.Timer();
			aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
			aTimer.Interval = 5000; // ~ 1 second
			aTimer.Enabled = true;
		}

		private void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			int nCPThreads;
			System.Threading.ThreadPool.GetAvailableThreads(out m_nAvailableThreads, out nCPThreads);

			if (txtAvailableThreads.InvokeRequired)
			{
				txtAvailableThreads.Invoke
				(
					new Action(() =>
					{
						txtAvailableThreads.Text = m_nAvailableThreads.ToString();
					}
					)
				);
			}
			else
			{
				txtAvailableThreads.Text = m_nAvailableThreads.ToString();
			}
		}

		private void OnStart(object sender, EventArgs e)
		{
			int nSelected = cmbThreadType.SelectedIndex;
			ComboItem item = cmbThreadType.Items[nSelected] as ComboItem;

			switch (item.Value)
			{
				case THREAD_TYPE.THREAD_TYPE_THREAD:
					StartThread();
					break;

				case THREAD_TYPE.THREAD_TYPE_TASK:
					StartTask();
					break;
			}
		}

		private void StartThread()
		{ 
			if (m_bRunning)
			{
				m_bCancel = true;
				m_bRunning = false;
				btnStart.Text = "&Start";

				while (m_lstActiveThreads.Count > 0)
				{
					Thread thrdItem = m_lstActiveThreads.First();
					m_lstActiveThreads.RemoveFirst();
					while (thrdItem.IsAlive)
					{
						System.Threading.Thread.Sleep(100);
					}
				}

				System.Diagnostics.Trace.WriteLine("All threads terminated");
			}
			else
			{
				btnStart.Text = "&Stop";
				m_bRunning = true;
				m_bCancel = false;
				int nMax = (int)numThreads.Value;
				for (int nIx = 0; nIx < nMax; nIx++)
				{
					Object objCount = nIx + 1;
					double result = 0d;

					Thread myThread = new Thread(() => result = IntensiveCalcs(objCount));
					m_lstActiveThreads.AddLast(myThread);

					myThread.IsBackground = true;
					myThread.Priority = ThreadPriority.BelowNormal;
					myThread.Start();
				}
			}
		}

		private void StartTask()
		{
			if (m_bRunning)
			{
				m_bCancel = true;
				m_bRunning = false;
				btnStart.Text = "&Start";

				Task[] tskItems = m_lstActiveTasks.ToArray<Task>();
				Task.WaitAll(tskItems);

				m_lstActiveTasks.Clear();

				System.Diagnostics.Trace.WriteLine("All tasks completed");
			}
			else
			{
				btnStart.Text = "&Stop";
				m_bRunning = true;
				m_bCancel = false;
				int nMax = (int)numThreads.Value;
				for (int nIx = 0; nIx < nMax; nIx++)
				{
					Object objCount = nIx + 1;

					double result = 0d;

					Task myTask = new Task(() => result = IntensiveCalcs(objCount));
					m_lstActiveTasks.AddLast(myTask);
					myTask.Start();
				}
			}
		}

		double IntensiveCalcs(Object objCount)
		{
			int nThreadID = (objCount == null) ? 0 : (int)objCount;
			Stopwatch sw = Stopwatch.StartNew();

			Trace.WriteLine(String.Format($"Thread {nThreadID} starting"));

			double result = 100000000d;
			Int32 maxValue = Int32.MaxValue;
			for (int nIx=1; nIx<maxValue; nIx++)
			{
				result /= nIx;
				if (m_bCancel)
					break;
			}

			sw.Stop();
			Trace.WriteLine(String.Format($"Thread {nThreadID} ending - Time elapsed = {sw.ElapsedMilliseconds} mSecs"));

			return result;
		}

		LinkedList<Thread> m_lstActiveThreads = new LinkedList<Thread>();
		LinkedList<Task> m_lstActiveTasks = new LinkedList<Task>();

		bool m_bCancel = false;
		bool m_bRunning = false;
		int m_nAvailableThreads;
	}
}
