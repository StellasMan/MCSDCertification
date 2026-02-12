namespace BackgroundWorkerDemo
{
    partial class BackgroundWorkerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pbarBackground = new ProgressBar();
			btnStart = new Button();
			label1 = new Label();
			nudSeconds = new NumericUpDown();
			lblPct = new Label();
			label2 = new Label();
			lblElapsed = new Label();
			((System.ComponentModel.ISupportInitialize)nudSeconds).BeginInit();
			SuspendLayout();
			// 
			// pbarBackground
			// 
			pbarBackground.BackColor = Color.Lime;
			pbarBackground.ForeColor = Color.Red;
			pbarBackground.Location = new Point(50, 180);
			pbarBackground.Name = "pbarBackground";
			pbarBackground.Size = new Size(355, 23);
			pbarBackground.Style = ProgressBarStyle.Continuous;
			pbarBackground.TabIndex = 0;
			// 
			// btnStart
			// 
			btnStart.Location = new Point(205, 116);
			btnStart.Name = "btnStart";
			btnStart.Size = new Size(75, 23);
			btnStart.TabIndex = 1;
			btnStart.Text = "&Start";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += OnStart;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(142, 72);
			label1.Name = "label1";
			label1.Size = new Size(77, 15);
			label1.TabIndex = 2;
			label1.Text = "# of seconds:";
			// 
			// nudSeconds
			// 
			nudSeconds.Location = new Point(243, 70);
			nudSeconds.Name = "nudSeconds";
			nudSeconds.Size = new Size(59, 23);
			nudSeconds.TabIndex = 3;
			// 
			// lblPct
			// 
			lblPct.AutoSize = true;
			lblPct.Location = new Point(411, 184);
			lblPct.Name = "lblPct";
			lblPct.Size = new Size(23, 15);
			lblPct.TabIndex = 4;
			lblPct.Text = "0%";
			lblPct.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(140, 214);
			label2.Name = "label2";
			label2.Size = new Size(176, 15);
			label2.TabIndex = 5;
			label2.Text = "Actual Elapsed Time in seconds:";
			// 
			// lblElapsed
			// 
			lblElapsed.AutoSize = true;
			lblElapsed.Location = new Point(322, 214);
			lblElapsed.Name = "lblElapsed";
			lblElapsed.Size = new Size(34, 15);
			lblElapsed.TabIndex = 6;
			lblElapsed.Text = "0.000";
			lblElapsed.TextAlign = ContentAlignment.TopCenter;
			// 
			// BackgroundWorkerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 261);
			Controls.Add(lblElapsed);
			Controls.Add(label2);
			Controls.Add(lblPct);
			Controls.Add(nudSeconds);
			Controls.Add(label1);
			Controls.Add(btnStart);
			Controls.Add(pbarBackground);
			Name = "BackgroundWorkerForm";
			Text = "BackgroudWorker Demo";
			((System.ComponentModel.ISupportInitialize)nudSeconds).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ProgressBar pbarBackground;
		private Button btnStart;
		private Label label1;
		private NumericUpDown nudSeconds;
		private Label lblPct;
		private Label label2;
		private Label lblElapsed;
	}
}
