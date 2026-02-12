namespace Events
{
	partial class EventForm
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
			this.m_scSpeedometer = new Events.SpeedControl();
			this.m_trkbarGasPedal = new Events.EventTrackBar();
			this.btnHandler = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.m_trkbarGasPedal)).BeginInit();
			this.SuspendLayout();
			// 
			// m_scSpeedometer
			// 
			this.m_scSpeedometer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m_scSpeedometer.BackColor = System.Drawing.SystemColors.Window;
			this.m_scSpeedometer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_scSpeedometer.Location = new System.Drawing.Point(12, 12);
			this.m_scSpeedometer.Name = "m_scSpeedometer";
			this.m_scSpeedometer.Size = new System.Drawing.Size(460, 450);
			this.m_scSpeedometer.TabIndex = 0;
			// 
			// m_trkbarGasPedal
			// 
			this.m_trkbarGasPedal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m_trkbarGasPedal.LargeChange = 20;
			this.m_trkbarGasPedal.Location = new System.Drawing.Point(12, 516);
			this.m_trkbarGasPedal.Maximum = 130;
			this.m_trkbarGasPedal.Name = "m_trkbarGasPedal";
			this.m_trkbarGasPedal.Size = new System.Drawing.Size(212, 45);
			this.m_trkbarGasPedal.SmallChange = 20;
			this.m_trkbarGasPedal.TabIndex = 1;
			// 
			// btnHandler
			// 
			this.btnHandler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHandler.Location = new System.Drawing.Point(334, 527);
			this.btnHandler.Name = "btnHandler";
			this.btnHandler.Size = new System.Drawing.Size(127, 23);
			this.btnHandler.TabIndex = 2;
			this.btnHandler.Text = "&Add Event Handler";
			this.btnHandler.UseVisualStyleBackColor = true;
			this.btnHandler.Click += new System.EventHandler(this.OnAddEventHandler);
			// 
			// EventForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 585);
			this.Controls.Add(this.btnHandler);
			this.Controls.Add(this.m_trkbarGasPedal);
			this.Controls.Add(this.m_scSpeedometer);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "EventForm";
			this.Text = "Event Testing";
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_trkbarGasPedal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SpeedControl m_scSpeedometer;
		public EventTrackBar m_trkbarGasPedal;
		private System.Windows.Forms.Button btnHandler;
	}
}

