using System.Diagnostics;
using System.DirectoryServices;

namespace Finalize
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnCreate(object sender, EventArgs e)
		{
			lstPeople.AddLast(new Person("John", "Doe"));
			lstPeople.AddLast(new Person("Jane", "Doe"));
			lstPeople.AddLast(new Person("Sam", "Smith"));
			lstPeople.AddLast(new Person("Don", "Jones"));
			lstPeople.AddLast(new Person("Sue", "Smith"));
			lstPeople.AddLast(new Person("Bob", "Brown"));
			lstPeople.AddLast(new Person("Sally", "Smith"));
		}

		private void OnDispose(object sender, EventArgs e)
		{
			bool bDispose = true;
			Stack<Person> stackPeople = new Stack<Person>();
			while (lstPeople.Count > 0)
			{
				foreach (Person person in lstPeople)
				{
					// Dispose of every other person object
					if (person is not null)
					{
						if (bDispose)
						{
							stackPeople.Push(person);
						}

						bDispose = !bDispose;
					}
				}

				// Remove disposed objects from the list
				while (stackPeople.Count > 0)
				{
					Person person = stackPeople.Pop();
					lstPeople.Remove(person);
					person.Dispose();
				}

				lstPeople.Clear();
			}
		}

		private void OnCollect(object sender, EventArgs e)
		{
			GC.Collect();
		}

		private void OnUsing(object sender, EventArgs e)
		{
			foreach(Person person in lstPeople)
			{
				using (person)
				{
					Trace.WriteLine(String.Format("Using person: {0}, {1} ID: {2}", person.LastName, person.FirstName, person.ID));
				}
			}

			GC.Collect();
		}

		private LinkedList<Person> lstPeople = new LinkedList<Person>();
	}
}
