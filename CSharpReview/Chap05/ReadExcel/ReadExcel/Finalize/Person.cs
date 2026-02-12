using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalize
{
	public class Person : IDisposable
	{
		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
			ID = ++nextID;


			Random rand = new Random((int)DateTime.Now.Ticks);
			m_brushRed = new SolidBrush(Color.Red);
			Color clrRand = Color.FromArgb(255, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
			m_brushRandom = new SolidBrush(clrRand);

			Trace.WriteLine(String.Format("Created brush RGB({0}, {1}, {2})", clrRand.R, clrRand.G, clrRand.B));

			ResourcesFreed = false;
		}

		public void Dispose()
		{
			Trace.WriteLine(String.Format("Disposing of Person object with ID: {0}", ID));
			FreeResources(true);
		}

		~Person()
		{
			Trace.WriteLine(String.Format("Deleting Person object with ID: {0}", ID));
			FreeResources(false);
		}

		private void FreeResources(bool freeManaged)
		{
			if (freeManaged)
			{
				m_brushRed.Dispose();
				m_brushRandom.Dispose();

				Console.WriteLine("Freeing managed resources for Person object with ID: {0}", ID);
			}

			// Free unmanaged resources
			Console.WriteLine("Freeing unmanaged resources for Person object with ID: {0}", ID);

			ResourcesFreed = true;
			GC.SuppressFinalize(this);
		}

		static int nextID = 0;
		SolidBrush m_brushRed;
		SolidBrush m_brushRandom;
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int ID { get; set; }

		private bool ResourcesFreed { get; set; }
	}
}
