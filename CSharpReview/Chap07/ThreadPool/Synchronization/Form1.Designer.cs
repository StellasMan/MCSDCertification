namespace Synchronization
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
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtThread1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtThread3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtThread2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtThread4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRelease = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(263, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thread Total:";
			// 
			// txtTotal
			// 
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(350, 163);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 1;
			// 
			// txtThread1
			// 
			this.txtThread1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtThread1.Enabled = false;
			this.txtThread1.Location = new System.Drawing.Point(350, 23);
			this.txtThread1.Name = "txtThread1";
			this.txtThread1.Size = new System.Drawing.Size(100, 20);
			this.txtThread1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(263, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Thread 1 Total:";
			// 
			// txtThread3
			// 
			this.txtThread3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtThread3.Enabled = false;
			this.txtThread3.Location = new System.Drawing.Point(350, 81);
			this.txtThread3.Name = "txtThread3";
			this.txtThread3.Size = new System.Drawing.Size(100, 20);
			this.txtThread3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(263, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Thread 3 Total:";
			// 
			// txtThread2
			// 
			this.txtThread2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtThread2.Enabled = false;
			this.txtThread2.Location = new System.Drawing.Point(350, 52);
			this.txtThread2.Name = "txtThread2";
			this.txtThread2.Size = new System.Drawing.Size(100, 20);
			this.txtThread2.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(263, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Thread 2 Total:";
			// 
			// txtThread4
			// 
			this.txtThread4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtThread4.Enabled = false;
			this.txtThread4.Location = new System.Drawing.Point(350, 110);
			this.txtThread4.Name = "txtThread4";
			this.txtThread4.Size = new System.Drawing.Size(100, 20);
			this.txtThread4.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(263, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Thread 4 Total:";
			// 
			// btnRelease
			// 
			this.btnRelease.Location = new System.Drawing.Point(26, 160);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(97, 23);
			this.btnRelease.TabIndex = 10;
			this.btnRelease.Text = "&Release Thread";
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.OnRelease);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(138, 160);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRelease);
			this.Controls.Add(this.txtThread4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtThread2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtThread3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtThread1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Form1";
			this.Text = "Synchronization";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtThread1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtThread3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtThread2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtThread4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRelease;
		private System.Windows.Forms.Button btnCancel;
	}
}

