using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace AppFive1
{
	public class Person
	{
		public Person(String first, String last, String street, String city, char[] state, String zip)
		{
			Trace.WriteLine("Person ctor");

			First = first;
			Last = last;
			Street = street;
			City = city;
			State = state;
			Zip = zip;
		}

		public override string ToString()
		{
			return String.Format("{0}|{1}|{2}|{3}|{4}|{5}", First, Last, Street, City, new String(State), Zip);
		}

		public string First { get; set; }
		public string Last { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public char[] State 
		{
			get;
			//set => field = (value.Length == 2) ? value : new char[] { '\0', '\0' };
			set
			{
				if (value.Length == 2)
					field = value;
				else
					field = new char[] { '\0', '\0' };
			}
		}

		public string Zip{ get; set; }
	}

	public class Employee : Person, IComparable<Employee>
	{
		public Employee(String first, String last, String street, String city, char[] state, String zip, int employeeID)
			: base(first, last, street, city, state, zip)
		{
			Trace.WriteLine("Employee ctor");
			EmployeeID = employeeID;
		}

		public int CompareTo(Employee src)
		{
			string thisStr = ToString();
			string srcStr = src.ToString();

			return thisStr.CompareTo(srcStr);
		}

		public override string ToString()
		{
			return base.ToString() + String.Format("|{0}", EmployeeID);
		}

		public int EmployeeID { get; set; }
	}
}
