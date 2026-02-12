namespace ThreadLocalApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.nudStartValue = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudEndValue = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "# of Threads:";
			// 
			// nudThreads
			// 
			this.nudThreads.Location = new System.Drawing.Point(260, 67);
			this.nudThreads.Name = "nudThreads";
			this.nudThreads.Size = new System.Drawing.Size(58, 20);
			this.nudThreads.TabIndex = 1;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudStartValue
			// 
			this.nudStartValue.Location = new System.Drawing.Point(169, 122);
			this.nudStartValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudStartValue.Name = "nudStartValue";
			this.nudStartValue.Size = new System.Drawing.Size(58, 20);
			this.nudStartValue.TabIndex = 2;
			this.nudStartValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudStartValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(92, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Starting Value:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ending Value:";
			// 
			// nudEndValue
			// 
			this.nudEndValue.Location = new System.Drawing.Point(334, 122);
			this.nudEndValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudEndValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudEndValue.Name = "nudEndValue";
			this.nudEndValue.Size = new System.Drawing.Size(58, 20);
			this.nudEndValue.TabIndex = 4;
			this.nudEndValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudEndValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(205, 177);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudEndValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nudStartValue);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Form1";
			this.Text = "Thread Local Demo";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStartValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEndValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.NumericUpDown nudStartValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudEndValue;
		private System.Windows.Forms.Button btnStart;
	}
}

