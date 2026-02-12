namespace Finalize
{
	partial class Form1
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
			btnCreate = new Button();
			btnDispose = new Button();
			btnCollect = new Button();
			btnUsing = new Button();
			SuspendLayout();
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(46, 121);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(75, 23);
			btnCreate.TabIndex = 0;
			btnCreate.Text = "&Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += OnCreate;
			// 
			// btnDispose
			// 
			btnDispose.Name = "btnDispose";
			btnDispose.Size = new Size(75, 23);
			btnDispose.TabIndex = 1;
			btnDispose.Text = "&Dispose";
			btnDispose.UseVisualStyleBackColor = true;
			btnDispose.Click += OnDispose;
			// 
			// btnCollect
			// 
			btnCollect.Name = "btnCollect";
			btnCollect.Size = new Size(75, 23);
			btnCollect.TabIndex = 2;
			btnCollect.Text = "&Collect";
			btnCollect.UseVisualStyleBackColor = true;
			btnCollect.Click += OnCollect;
			// 
			// btnUsing
			// 
			btnUsing.Location = new Point(361, 121);
			btnUsing.Name = "btnUsing";
			btnUsing.Size = new Size(75, 23);
			btnUsing.TabIndex = 3;
			btnUsing.Text = "&Using";
			btnUsing.UseVisualStyleBackColor = true;
			btnUsing.Click += OnUsing;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 261);
			Controls.Add(btnUsing);
			Controls.Add(btnCollect);
			Controls.Add(btnDispose);
			Controls.Add(btnCreate);
			MinimumSize = new Size(500, 300);
			Name = "Form1";
			Text = "Finalize";
			ResumeLayout(false);
		}

		#endregion

		private Button btnCreate;
		private Button btnDispose;
		private Button btnCollect;
		private Button btnUsing;
	}
}
