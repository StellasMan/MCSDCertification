using System;
using static Delegates.CustomControl;

namespace Delegates
{
	public partial class formDelegate : Form
	{
		public formDelegate()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			int nIndx = m_cmbFuncs.Items.Add("Sine");
			m_cmbFuncs.Items[nIndx] = FuncTypeEnum.Sin;

			nIndx = m_cmbFuncs.Items.Add("Cosine");
			m_cmbFuncs.Items[nIndx] = FuncTypeEnum.Cos;

			nIndx = m_cmbFuncs.Items.Add("Tangent");
			m_cmbFuncs.Items[nIndx] = FuncTypeEnum.Tan;

			nIndx = m_cmbFuncs.Items.Add("Polynomial");
			m_cmbFuncs.Items[nIndx] = FuncTypeEnum.Polynomial;

			m_cmbFuncs.SelectedIndex = 0;
		}

		private void OnFuncChanged(object sender, EventArgs e)
		{
			Object? objValue = m_cmbFuncs.Items[m_cmbFuncs.SelectedIndex];
			if (objValue != null)
			{
				FuncTypeEnum funcTypeEnum = (FuncTypeEnum)objValue;
				m_ccntrlImage.FuncType = funcTypeEnum;
			}
		}
	}
}