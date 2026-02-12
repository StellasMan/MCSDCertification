namespace ThreadPool
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
			this.txtMaxThreads = new System.Windows.Forms.TextBox();
			this.txtAvailableThreads = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numThreads = new System.Windows.Forms.NumericUpDown();
			this.cmbThreadType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Maximum Thread Pool Threads:";
			// 
			// txtMaxThreads
			// 
			this.txtMaxThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaxThreads.Enabled = false;
			this.txtMaxThreads.Location = new System.Drawing.Point(175, 27);
			this.txtMaxThreads.Name = "txtMaxThreads";
			this.txtMaxThreads.Size = new System.Drawing.Size(86, 20);
			this.txtMaxThreads.TabIndex = 1;
			this.txtMaxThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAvailableThreads
			// 
			this.txtAvailableThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAvailableThreads.Enabled = false;
			this.txtAvailableThreads.Location = new System.Drawing.Point(175, 64);
			this.txtAvailableThreads.Name = "txtAvailableThreads";
			this.txtAvailableThreads.Size = new System.Drawing.Size(86, 20);
			this.txtAvailableThreads.TabIndex = 3;
			this.txtAvailableThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Available Thread Pool Threads:";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(205, 216);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "&Number of threads to create:";
			// 
			// numThreads
			// 
			this.numThreads.Location = new System.Drawing.Point(175, 101);
			this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numThreads.Name = "numThreads";
			this.numThreads.Size = new System.Drawing.Size(86, 20);
			this.numThreads.TabIndex = 6;
			this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cmbThreadType
			// 
			this.cmbThreadType.FormattingEnabled = true;
			this.cmbThreadType.Location = new System.Drawing.Point(175, 161);
			this.cmbThreadType.Name = "cmbThreadType";
			this.cmbThreadType.Size = new System.Drawing.Size(121, 21);
			this.cmbThreadType.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "&Threading Type:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbThreadType);
			this.Controls.Add(this.numThreads);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtAvailableThreads);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMaxThreads);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Form1";
			this.Text = "Thread Pool";
			((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaxThreads;
		private System.Windows.Forms.TextBox txtAvailableThreads;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numThreads;
		private System.Windows.Forms.ComboBox cmbThreadType;
		private System.Windows.Forms.Label label4;
	}
}

