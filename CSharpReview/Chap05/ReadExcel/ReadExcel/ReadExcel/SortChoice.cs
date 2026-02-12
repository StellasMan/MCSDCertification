using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadExcel
{
	public partial class SortChoice : Form
	{
		public SortChoice()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			m_SortBy = StudentComparer.SortBy.NAME;
			radioName.Checked = true;
			radAscending.Checked = true;
		}

		private void radioName_CheckedChanged(object sender, EventArgs e)
		{
			m_SortBy = StudentComparer.SortBy.NAME;
		}

		private void radioStudID_CheckedChanged(object sender, EventArgs e)
		{
			m_SortBy = StudentComparer.SortBy.STUDENTID;
		}

		private void radioGPA_CheckedChanged(object sender, EventArgs e)
		{
			m_SortBy = StudentComparer.SortBy.GPA;
		}

		// Read-only outside this class
		public StudentComparer.SortBy SortBy
		{
			get { return m_SortBy; }
		}

		public bool SortAscending
		{
			get { return radAscending.Checked; }
		}

		private StudentComparer.SortBy m_SortBy;
	}
}
