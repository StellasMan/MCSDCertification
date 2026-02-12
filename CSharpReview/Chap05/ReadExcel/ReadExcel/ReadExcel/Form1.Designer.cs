namespace ReadExcel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnImport = new System.Windows.Forms.Button();
			this.lvContacts = new System.Windows.Forms.ListView();
			this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.County = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Zip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CellPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HomePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnCreateTree = new System.Windows.Forms.Button();
			this.btnEnumerate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImport.Enabled = false;
			this.btnImport.Location = new System.Drawing.Point(16, 226);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 0;
			this.btnImport.Text = "&Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.OnImport);
			// 
			// lvContacts
			// 
			this.lvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LastName,
            this.FirstName,
            this.Address,
            this.City,
            this.County,
            this.State,
            this.Zip,
            this.CellPhone,
            this.HomePhone,
            this.EMail,
            this.StudentID,
            this.GPA});
			this.lvContacts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvContacts.HideSelection = false;
			this.lvContacts.Location = new System.Drawing.Point(16, 55);
			this.lvContacts.MultiSelect = false;
			this.lvContacts.Name = "lvContacts";
			this.lvContacts.Size = new System.Drawing.Size(460, 154);
			this.lvContacts.TabIndex = 1;
			this.lvContacts.UseCompatibleStateImageBehavior = false;
			this.lvContacts.View = System.Windows.Forms.View.Details;
			// 
			// LastName
			// 
			this.LastName.Text = "Last Name";
			// 
			// FirstName
			// 
			this.FirstName.Text = "First Name";
			// 
			// LastName
			// 
			this.LastName.Text = "Last Name";
			// 
			// Address
			// 
			this.Address.Text = "Address";
			// 
			// City
			// 
			this.City.Text = "City";
			// 
			// County
			// 
			this.County.Text = "County";
			// 
			// State
			// 
			this.State.Text = "State";
			// 
			// Zip
			// 
			this.Zip.Text = "Zip";
			// 
			// CellPhone
			// 
			this.CellPhone.Text = "Cell Phone";
			// 
			// HomePhone
			// 
			this.HomePhone.Text = "Home Phone";
			// 
			// EMail
			// 
			this.EMail.Text = "EMail";
			// 
			// StudentID
			// 
			this.StudentID.Text = "Student ID";
			// 
			// GPA
			// 
			this.GPA.Text = "GPA";
			this.GPA.Width = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "&File Path:";
			// 
			// txtFilePath
			// 
			this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilePath.Location = new System.Drawing.Point(70, 27);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(363, 20);
			this.txtFilePath.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(439, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 23);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnFileSelect);
			// 
			// btnSort
			// 
			this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSort.Location = new System.Drawing.Point(111, 226);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 5;
			this.btnSort.Text = "&Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.OnSort);
			// 
			// btnCreateTree
			// 
			this.btnCreateTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCreateTree.Location = new System.Drawing.Point(206, 226);
			this.btnCreateTree.Name = "btnCreateTree";
			this.btnCreateTree.Size = new System.Drawing.Size(75, 23);
			this.btnCreateTree.TabIndex = 6;
			this.btnCreateTree.Text = "&Create Tree";
			this.btnCreateTree.UseVisualStyleBackColor = true;
			this.btnCreateTree.Click += new System.EventHandler(this.OnCreateTree);
			// 
			// btnEnumerate
			// 
			this.btnEnumerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEnumerate.Location = new System.Drawing.Point(301, 226);
			this.btnEnumerate.Name = "btnEnumerate";
			this.btnEnumerate.Size = new System.Drawing.Size(75, 23);
			this.btnEnumerate.TabIndex = 7;
			this.btnEnumerate.Text = "&Enumerate";
			this.btnEnumerate.UseVisualStyleBackColor = true;
			this.btnEnumerate.Click += new System.EventHandler(this.OnEnumerate);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnEnumerate);
			this.Controls.Add(this.btnCreateTree);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvContacts);
			this.Controls.Add(this.btnImport);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Form1";
			this.Text = "Input Excel File";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.ListView lvContacts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader FirstName;
		private System.Windows.Forms.ColumnHeader LastName;
		private System.Windows.Forms.ColumnHeader Address;
		private System.Windows.Forms.ColumnHeader City;
		private System.Windows.Forms.ColumnHeader County;
		private System.Windows.Forms.ColumnHeader Zip;
		private System.Windows.Forms.ColumnHeader CellPhone;
		private System.Windows.Forms.ColumnHeader HomePhone;
		private System.Windows.Forms.ColumnHeader EMail;
		private System.Windows.Forms.ColumnHeader State;
		private System.Windows.Forms.ColumnHeader StudentID;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.ColumnHeader GPA;
		private System.Windows.Forms.Button btnCreateTree;
		private System.Windows.Forms.Button btnEnumerate;
	}
}

