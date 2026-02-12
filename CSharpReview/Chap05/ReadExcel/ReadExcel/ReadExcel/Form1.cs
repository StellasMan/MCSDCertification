using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReadExcel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnFileSelect(object sender, EventArgs e)
		{
			txtFilePath.Clear();
			btnImport.Enabled = false;
			lvContacts.Items.Clear();

			while (true)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();

				openFileDialog.Title = "Select source file to import";

				// Move up two directories from the executing assembly
				string currDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				currDir = Directory.GetParent(currDir).FullName;
				currDir = Directory.GetParent(currDir).FullName;
				openFileDialog.InitialDirectory = currDir;

				openFileDialog.Filter = ".csv file (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;

				DialogResult result = openFileDialog.ShowDialog();
				if (result == DialogResult.Cancel)
				{
					break;
				}
				else if (result == DialogResult.OK)
				{
					if (openFileDialog.CheckFileExists)
					{
						txtFilePath.Text = openFileDialog.FileName;
						btnImport.Enabled = true;
						OnImport(sender, e);
						break;
					}
					else
					{
						MessageBox.Show("File not found");
					}
				}
			}
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			// Set the view to show details.
			lvContacts.View = View.Details;

			// Allow the user to edit item text.
			lvContacts.LabelEdit = true;
			
			// Allow the user to rearrange columns.
			lvContacts.AllowColumnReorder = true;
			
			// Select the item and subitems when selection is made.
			lvContacts.FullRowSelect = true;
			
			// Display grid lines.
			lvContacts.GridLines = true;
		}

		private void OnImport(object sender, EventArgs e)
		{
			Random random = new Random();

			m_lstStudents.Clear();

			string[] lines = File.ReadAllLines(txtFilePath.Text);
			bool bFirst = true;
			foreach (string line in lines)
			{
				List<String> lstItems = new List<string>();
				if (!bFirst)
				{
					string[] rawItems = line.Split(',');
					string strItem = "";
					bool bInQuotes = false;
					foreach (string part in rawItems)
					{
						string item = part.Trim();
						if (item.StartsWith("\""))
						{
							strItem = item.Substring(1);
							bInQuotes = true;
						}
						else if (item.EndsWith("\""))
						{
							strItem += ", " + item.Replace("\"", "");
							lstItems.Add(strItem);
							strItem = "";
							bInQuotes = false;
						}
						else if (bInQuotes)
						{
							strItem += ", " + item;
						}
						else
						{
							lstItems.Add(item);
						}
					}

					if (lstItems.Count > 0)
					{
						String studentId = String.Format("{0}{1}", random.Next(100,999), random.Next(100,999));
						lstItems.Add(studentId);
						int studentID = Convert.ToInt32(studentId);

						float gpa = (float)(random.Next(100, 400) / 100.0);
						lstItems.Add(gpa.ToString("0.00"));

						lstItems.RemoveAt(2);
						string[] arrItems = lstItems.ToArray();

						// Create a new student object and add it to the list
						Student student = new Student(arrItems[0], arrItems[1], arrItems[2], arrItems[3], arrItems[4], arrItems[5], arrItems[6], arrItems[7], arrItems[8], arrItems[9], studentID, gpa);
						m_lstStudents.Add(student);
					}
				}
				else
				{
					bFirst = false;
				}
			}

			DisplayStudents();

			foreach (ColumnHeader ch in lvContacts.Columns)
			{
				ch.Width = -1;
			}
		}

		private void OnSort(object sender, EventArgs e)
		{
			SortChoice sortChoice = new SortChoice();
			DialogResult result = sortChoice.ShowDialog();
			if (result == DialogResult.OK)
			{
				m_lstStudents.Sort(new StudentComparer(sortChoice.SortBy, sortChoice.SortAscending));
				DisplayStudents();
			}
		}

		private void DisplayStudents()
		{
			lvContacts.Items.Clear();
			foreach (Student student in m_lstStudents)
			{
				string[] arrItems = new string[12];
				arrItems[0] = student.LastName;
				arrItems[1] = student.FirstName;
				arrItems[2] = student.Street;
				arrItems[3] = student.City;
				arrItems[4] = student.County;
				arrItems[5] = student.State;
				arrItems[6] = student.Zip;
				arrItems[7] = student.CellPhone;
				arrItems[8] = student.HomePhone;
				arrItems[9] = student.eMail;
				arrItems[10] = student.StudentID.ToString();
				arrItems[11] = student.GPA.ToString("0.00");
				ListViewItem lvi = new ListViewItem(arrItems);
				lvContacts.Items.Add(lvi);
			}
		}

		private void OnCreateTree(object sender, EventArgs e)
		{
			SortChoice sortChoice = new SortChoice();
			DialogResult result = sortChoice.ShowDialog();
			if (result == DialogResult.OK)
			{
				m_treeStudents.Clear();
				m_treeStudents.m_studentComparer = new StudentComparer(sortChoice.SortBy, sortChoice.SortAscending);
				foreach (Student student in m_lstStudents)
				{
					m_treeStudents.Add(student);
				}
			}
		}

		private void OnEnumerate(object sender, EventArgs e)
		{
			OnCreateTree(sender, e);

			IEnumerable<Student> studentEnum = m_treeStudents as IEnumerable<Student>;
			StudentTreeEnumerator enumStudent = (StudentTreeEnumerator)studentEnum.GetEnumerator();
			enumStudent.Reset();
			int nCount = 0;
			while (enumStudent.Current != null)
			{
				nCount++;
				Student student = enumStudent.Current;
				String studentName = String.Format("{0}, {1}", student.LastName, student.FirstName);	
				Console.WriteLine(String.Format("{3,2}) {0,-30}: {1,6}, {2,4:F2}", studentName, student.StudentID, student.GPA, nCount));
				enumStudent.MoveNext();
			}
		}

		private StudentTree m_treeStudents = new StudentTree();
		private List<Student> m_lstStudents = new List<Student>();
	}
}
