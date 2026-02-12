using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadExcel
{
	public class Student : IComparable<Student>
	{
		public Student(String firstName, String lastName, String street, String city, String county, String state, string zip, String cellPhone, String homePhone, String eMail, Int32 studentID, float gpa)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Street = street;
			this.City = city;
			this.County = county;
			this.State = state;
			this.Zip = zip;
			this.CellPhone = cellPhone;
			this.HomePhone = homePhone;
			this.eMail = eMail;
			this.StudentID = studentID;
			this.GPA = gpa;
		}

		public String FirstName { get; }
		public String LastName { get; }
		public String Street { get; }
		public String City { get; }
		public String County { get; }
		public String State { get; }
		public String Zip { get; }
		public String CellPhone { get; }
		public String HomePhone { get; }
		public String eMail { get; }
		public Int32 StudentID { get; }
		public float GPA { get; }

		int IComparable<Student>.CompareTo(Student other)
		{
			return String.Format("{0}|{1}", this.LastName, this.FirstName).CompareTo(String.Format("{0}|{1}", other.LastName, other.FirstName));
		}
	}

	public class StudentComparer : IComparer<Student>
	{
		public enum SortBy
		{
			NAME,
			STUDENTID,
			GPA
		}

		public StudentComparer(SortBy sortBy, bool sortAscending)
		{
			m_sortBy = sortBy;
			m_sortAscending = sortAscending;
		}

		public int Compare(Student x, Student y)
		{
			return ((IComparer<Student>)this).Compare(x, y);
		}

		int IComparer<Student>.Compare(Student x, Student y)
		{
			int nRet = 0;
			if (m_sortBy == SortBy.NAME)
				nRet = String.Format("{0}|{1}", x.LastName, x.FirstName).CompareTo(String.Format("{0}|{1}", y.LastName, y.FirstName));
			else if (m_sortBy == SortBy.STUDENTID)
				nRet = x.StudentID.CompareTo(y.StudentID);
			else
				nRet = (x.GPA.CompareTo(y.GPA));

			if (!m_sortAscending)	
			{
				nRet = -nRet;
			}

			return nRet;
		}

		private SortBy m_sortBy;
		private bool m_sortAscending;
	}
}
