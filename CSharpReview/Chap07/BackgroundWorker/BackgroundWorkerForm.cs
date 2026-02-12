using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Timers;

using System.Windows.Forms; // Use appropriate UI namespace (e.g., System.Windows for WPF)

namespace BackgroundWorkerDemo
{
	public partial class BackgroundWorkerForm : Form
	{
		private BackgroundWorker backgroundWorker = new BackgroundWorker();
		private System.Timers.Timer aTimer = new System.Timers.Timer(1000);
		private DateTime startTime;

		public BackgroundWorkerForm()
		{
			InitializeComponent();
			nudSeconds.Value = 10; // Set default value for seconds
			pbarBackground.Minimum = 0;
			pbarBackground.Maximum = 100;
			pbarBackground.Value = 0;

			SetupBackgroundWorker();
			SetupTimer();
		}

		private void SetupTimer()
		{
			aTimer.Elapsed += OnTimedEvent;
			// The timer will fire the Elapsed event repeatedly (auto-reset to true)
			aTimer.AutoReset = true;
			// Start the timer
			aTimer.Enabled = false;
		}

		private void SetupBackgroundWorker()
		{
			// 1. Subscribe to the essential events
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

			// Optional: Enable progress reporting and cancellation if needed
			backgroundWorker.WorkerReportsProgress = true;

			aTimer.Enabled = true; // Start the timer when the background worker is set up
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
		}

		private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
		{
			pbarBackground.Value = e.ProgressPercentage; // Update progress bar with the reported percentage
			lblPct.Text = $"{e.ProgressPercentage}%"; // Update label to show percentage
		}

		private void OnStart(object sender, EventArgs e)
		{
			// Start the background operation
			if (!backgroundWorker.IsBusy)
			{
				btnStart.Text = "&Stop";
				int nSeconds = nudSeconds.Value > 0 ? (int)nudSeconds.Value : 1;

				aTimer.Enabled = true; // Start the timer when the background worker starts
				lblElapsed.Text = "0.000"; // Reset elapsed time label
				startTime = DateTime.Now; // Record the start time for elapsed time calculation
				backgroundWorker.RunWorkerAsync(nSeconds);
			}
			else
			{
				// If the worker is already running, request cancellation
				backgroundWorker.CancelAsync();
				btnStart.Text = "&Start";
				Debug.WriteLine("Cancellation requested.");
			}
		}

		// The method that runs on the background thread
		private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
		{
			// Retrieve argument if passed (e.Argument)
			int nSecondsToWait = (e.Argument as int?) ?? 0;
			Debug.WriteLine($"Waiting for {nSecondsToWait} seconds");

			// Perform time-consuming work here
			// Example: someFileProcessingMethod(parameter);
			int nPrevPct = -1;
			for (int i = 0; (!backgroundWorker.CancellationPending) && (i < (nSecondsToWait * 10)); i++)
			{
				System.Threading.Thread.Sleep(100); // Simulate work by sleeping for 1/10 seconds
				int nPct = (int)Math.Round(((decimal)((i + 1) * 10) / nSecondsToWait));
				if (nPct != nPrevPct)
				{
					backgroundWorker.ReportProgress(nPct); // Report progress as percentage
					nPrevPct = nPct;
				}
			}

			if (backgroundWorker.CancellationPending)
			{
				e.Cancel = true; // Set the Cancel property to true to indicate cancellation
				e.Result = "Operation Cancelled."; // Optionally set a result for cancellation
			}
			else
			{
				// Set the result to be accessed in the RunWorkerCompleted event
				e.Result = "Operation Completed Successfully!";
			}
		}

		// The method that runs back on the UI thread when work is done
		private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
		{
			btnStart.Text = "&Start"; // Reset button text
			aTimer.Enabled = false; // Stop the timer when the background worker completes

			if (e.Cancelled)
			{
				// Handle cancellation
				MessageBox.Show("Operation was cancelled.");
			}
			else if (e.Error != null)
			{
				// Handle any exceptions that occurred during DoWork
				MessageBox.Show($"An error occurred: {e.Error.Message}");
			}
			else
			{
				// Update UI elements with the result (e.Result)
				string result = e.Result as string ?? "Thread Complete";

				// Example: resultLabel.Text = result;
				MessageBox.Show(result);
			}
		}

		// Fix for CS0120: Change the OnTimedEvent method to be an instance method instead of static.
		// This allows it to access the instance member lblElapsed.

		private void OnTimedEvent(Object? source, ElapsedEventArgs e)
		{
			TimeSpan elapsed = DateTime.Now - startTime;
			string csSeconds = elapsed.TotalSeconds.ToString("F3"); // Format to 1 decimal place

			// Update label with elapsed time
			if (lblElapsed.InvokeRequired)
			{
				lblElapsed.Invoke(new Action(() => lblElapsed.Text = $"{csSeconds}"));
			}
			else
			{
				lblElapsed.Text = $"{csSeconds}";
			}
		}
	}
}
