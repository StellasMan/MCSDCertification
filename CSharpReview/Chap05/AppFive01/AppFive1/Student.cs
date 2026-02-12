using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFive1
{
	public class Student : Person, IComparable<Student>, IComparer<Student>
	{
		public Student(String first, String last, String street, String city, char[] state, String zip, int studentID)
			: base(first, last, street, city, state, zip)
		{
			StudentID = studentID;
		}

		public int CompareTo(Student src)
		{
			string thisStr = ToString();
			string srcStr = src.ToString();
			return thisStr.CompareTo(srcStr);
		}

		int IComparer<Student>.Compare(Student x, Student y)
		{
			throw new NotImplementedException();
		}

		public int StudentID { get; set; }
	}

	public class Class : IEnumerable<Student>
	{
		public Class() { }

		public void Add(Student student)
		{
			students.Add(student);
		}

		public IEnumerator<Student> GetEnumerator()
		{
			return new StudentEnum(students);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private List<Student> students = new List<Student>();
	}

	public class StudentEnum : IEnumerator<Student>
	{
		public StudentEnum(List<Student> students)
		{
			this.students = students;
		}

		// public Object Current => students[index];

		public bool MoveNext()
		{
			index++;
			return (index < students.Count);
		}

		public void Reset()
		{
			index = -1;
		}

		public void Dispose() { }

		private List<Student> students;
		private int index = -1;

		Student IEnumerator<Student>.Current => students[index];
		Object IEnumerator.Current => students[index];
	}
}
