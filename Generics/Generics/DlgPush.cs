using System;
using System.Windows.Forms;

namespace Generics
{
    public partial class DlgPush : Form
    {
        public DlgPush()
        {
            InitializeComponent();
        }

        public DlgPush(Int64 nValue)
        {
            InitializeComponent();

            ValueToPush = nValue;
            lblValue.Text = "Popped &Value:";
            txtValue.Text = String.Format("{0}", nValue);
            txtValue.Enabled = false;
        }

        public Int64 ValueToPush
        {
            get;
            set;
        }

        private void OnOK(object sender, EventArgs e)
        {
            Int64 nValue;
            if ((Int64.TryParse(txtValue.Text, out nValue)))
            {
                ValueToPush = nValue;
                btnOK.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(String.Format("Input '{0}' is not a valid number", txtValue.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnOK.DialogResult = DialogResult.None;
            }
        }
    }
}
