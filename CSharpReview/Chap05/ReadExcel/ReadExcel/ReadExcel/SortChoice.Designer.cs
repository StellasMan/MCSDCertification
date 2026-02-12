namespace ReadExcel
{
	partial class SortChoice
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
			this.radioName = new System.Windows.Forms.RadioButton();
			this.radioStudID = new System.Windows.Forms.RadioButton();
			this.radioGPA = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpSortField = new System.Windows.Forms.GroupBox();
			this.grpSortDir = new System.Windows.Forms.GroupBox();
			this.radAscending = new System.Windows.Forms.RadioButton();
			this.radDescending = new System.Windows.Forms.RadioButton();
			this.grpSortField.SuspendLayout();
			this.grpSortDir.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioName
			// 
			this.radioName.AutoSize = true;
			this.radioName.Location = new System.Drawing.Point(19, 32);
			this.radioName.Name = "radioName";
			this.radioName.Size = new System.Drawing.Size(53, 17);
			this.radioName.TabIndex = 0;
			this.radioName.TabStop = true;
			this.radioName.Text = "&Name";
			this.radioName.UseVisualStyleBackColor = true;
			this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
			// 
			// radioStudID
			// 
			this.radioStudID.AutoSize = true;
			this.radioStudID.Location = new System.Drawing.Point(90, 32);
			this.radioStudID.Name = "radioStudID";
			this.radioStudID.Size = new System.Drawing.Size(76, 17);
			this.radioStudID.TabIndex = 1;
			this.radioStudID.TabStop = true;
			this.radioStudID.Text = "&Student ID";
			this.radioStudID.UseVisualStyleBackColor = true;
			this.radioStudID.CheckedChanged += new System.EventHandler(this.radioStudID_CheckedChanged);
			// 
			// radioGPA
			// 
			this.radioGPA.AutoSize = true;
			this.radioGPA.Location = new System.Drawing.Point(194, 32);
			this.radioGPA.Name = "radioGPA";
			this.radioGPA.Size = new System.Drawing.Size(47, 17);
			this.radioGPA.TabIndex = 2;
			this.radioGPA.TabStop = true;
			this.radioGPA.Text = "&GPA";
			this.radioGPA.UseVisualStyleBackColor = true;
			this.radioGPA.CheckedChanged += new System.EventHandler(this.radioGPA_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(120, 224);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// grpSortField
			// 
			this.grpSortField.Controls.Add(this.radioName);
			this.grpSortField.Controls.Add(this.radioStudID);
			this.grpSortField.Controls.Add(this.radioGPA);
			this.grpSortField.Location = new System.Drawing.Point(23, 24);
			this.grpSortField.Name = "grpSortField";
			this.grpSortField.Size = new System.Drawing.Size(264, 82);
			this.grpSortField.TabIndex = 4;
			this.grpSortField.TabStop = false;
			this.grpSortField.Text = "Sort Field";
			// 
			// grpSortDir
			// 
			this.grpSortDir.Controls.Add(this.radDescending);
			this.grpSortDir.Controls.Add(this.radAscending);
			this.grpSortDir.Location = new System.Drawing.Point(23, 129);
			this.grpSortDir.Name = "grpSortDir";
			this.grpSortDir.Size = new System.Drawing.Size(264, 77);
			this.grpSortDir.TabIndex = 5;
			this.grpSortDir.TabStop = false;
			this.grpSortDir.Text = "Sort Direction";
			// 
			// radAscending
			// 
			this.radAscending.AutoSize = true;
			this.radAscending.Location = new System.Drawing.Point(35, 30);
			this.radAscending.Name = "radAscending";
			this.radAscending.Size = new System.Drawing.Size(75, 17);
			this.radAscending.TabIndex = 0;
			this.radAscending.TabStop = true;
			this.radAscending.Text = "&Ascending";
			this.radAscending.UseVisualStyleBackColor = true;
			// 
			// radDescending
			// 
			this.radDescending.AutoSize = true;
			this.radDescending.Location = new System.Drawing.Point(144, 30);
			this.radDescending.Name = "radDescending";
			this.radDescending.Size = new System.Drawing.Size(82, 17);
			this.radDescending.TabIndex = 1;
			this.radDescending.TabStop = true;
			this.radDescending.Text = "&Descending";
			this.radDescending.UseVisualStyleBackColor = true;
			// 
			// SortChoice
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 257);
			this.Controls.Add(this.grpSortDir);
			this.Controls.Add(this.grpSortField);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SortChoice";
			this.Text = "Choose Sort Type";
			this.Load += new System.EventHandler(this.OnLoad);
			this.grpSortField.ResumeLayout(false);
			this.grpSortField.PerformLayout();
			this.grpSortDir.ResumeLayout(false);
			this.grpSortDir.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioName;
		private System.Windows.Forms.RadioButton radioStudID;
		private System.Windows.Forms.RadioButton radioGPA;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.GroupBox grpSortField;
		private System.Windows.Forms.GroupBox grpSortDir;
		private System.Windows.Forms.RadioButton radDescending;
		private System.Windows.Forms.RadioButton radAscending;
	}
}