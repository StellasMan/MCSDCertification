using System;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Generics
{
    public partial class GenericForm : Form
    {
        GenStack<Int64> m_genGenericStack = new GenStack<Int64>();
    
        public GenericForm()
        {
            InitializeComponent();
        }

        private void OnPush(object sender, EventArgs e)
        {
            DlgPush dlgPush = new DlgPush();
            if (DialogResult.OK == dlgPush.ShowDialog())
            {
                m_genGenericStack.Push(dlgPush.ValueToPush);
                btnPop.Enabled = (m_genGenericStack.Count > 0) ? true : false;
            }
        }

        private void OnPop(object sender, EventArgs e)
        {
            try
            {
                Int64 nValue = m_genGenericStack.Pop();
                DlgPush dlgPush = new DlgPush(nValue);
                dlgPush.ShowDialog(this);
                btnPop.Enabled = (m_genGenericStack.Count > 0) ? true : false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(String.Format("Exception: '{0}'", ex.Message));
            }
        }
    }
}
