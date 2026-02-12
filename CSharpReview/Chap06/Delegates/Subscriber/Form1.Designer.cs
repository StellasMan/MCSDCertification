namespace Subscriber
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
			this.btnSubscribe = new System.Windows.Forms.Button();
			this.btnUnsubscribe = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSubscribe
			// 
			this.btnSubscribe.Location = new System.Drawing.Point(60, 102);
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.Size = new System.Drawing.Size(95, 23);
			this.btnSubscribe.TabIndex = 0;
			this.btnSubscribe.Text = "&Subscribe";
			this.btnSubscribe.UseVisualStyleBackColor = true;
			this.btnSubscribe.Click += new System.EventHandler(this.OnSubscribe);
			// 
			// btnUnsubscribe
			// 
			this.btnUnsubscribe.Location = new System.Drawing.Point(163, 102);
			this.btnUnsubscribe.Name = "btnUnsubscribe";
			this.btnUnsubscribe.Size = new System.Drawing.Size(95, 23);
			this.btnUnsubscribe.TabIndex = 1;
			this.btnUnsubscribe.Text = "&Unsubscribe";
			this.btnUnsubscribe.UseVisualStyleBackColor = true;
			this.btnUnsubscribe.Click += new System.EventHandler(this.OnUnsubscribe);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(278, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Count";
			// 
			// txtCount
			// 
			this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCount.Enabled = false;
			this.txtCount.Location = new System.Drawing.Point(266, 104);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(58, 20);
			this.txtCount.TabIndex = 3;
			this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnUnsubscribe);
			this.Controls.Add(this.btnSubscribe);
			this.MinimumSize = new System.Drawing.Size(400, 250);
			this.Name = "Form1";
			this.Text = "Subscriber Test";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSubscribe;
		private System.Windows.Forms.Button btnUnsubscribe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCount;
	}
}

