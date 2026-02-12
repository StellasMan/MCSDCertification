namespace Delegates
{
    partial class formDelegate
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
			m_ccntrlImage = new CustomControl();
			m_cmbFuncs = new ComboBox();
			m_txtLabel1 = new Label();
			SuspendLayout();
			// 
			// ccntrlImage
			// 
			m_ccntrlImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			m_ccntrlImage.BackColor = SystemColors.Window;
			m_ccntrlImage.BorderStyle = BorderStyle.FixedSingle;
			m_ccntrlImage.Location = new Point(29, 50);
			m_ccntrlImage.Name = "ccntrlImage";
			m_ccntrlImage.Size = new Size(421, 404);
			m_ccntrlImage.TabIndex = 0;
			// 
			// cmbFuncs
			// 
			m_cmbFuncs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			m_cmbFuncs.FormattingEnabled = true;
			m_cmbFuncs.Location = new Point(189, 11);
			m_cmbFuncs.Name = "cmbFuncs";
			m_cmbFuncs.Size = new Size(193, 23);
			m_cmbFuncs.TabIndex = 1;
			m_cmbFuncs.SelectedIndexChanged += OnFuncChanged;
			// 
			// label1
			// 
			m_txtLabel1.AutoSize = true;
			m_txtLabel1.Location = new Point(116, 15);
			m_txtLabel1.Name = "label1";
			m_txtLabel1.Size = new Size(57, 15);
			m_txtLabel1.TabIndex = 0;
			m_txtLabel1.Text = "&Function:";
			// 
			// formDelegate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 466);
			Controls.Add(m_txtLabel1);
			Controls.Add(m_cmbFuncs);
			Controls.Add(m_ccntrlImage);
			MinimumSize = new Size(500, 450);
			Name = "formDelegate";
			Text = "Delegates";
			Load += OnLoad;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private CustomControl m_ccntrlImage;
		private ComboBox m_cmbFuncs;
		private Label m_txtLabel1;
	}
}
