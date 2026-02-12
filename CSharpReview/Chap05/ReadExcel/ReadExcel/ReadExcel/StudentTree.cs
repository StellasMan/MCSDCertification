using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadExcel
{
	public class StudentNode
	{
		public StudentNode(Student student)
			: this(student, null)
		{
		}

		public StudentNode(Student student, StudentNode parent)
		{
			m_student = student;
			m_parent = parent;
			m_left = null;
			m_right = null;
		}

		public void Insert(Student student, StudentComparer studentComparer, StudentNode parentNode)
		{
			Console.WriteLine(String.Format("StudentNode::Insert: this.StudentID={0}; student.StudentID={1}; parent.StudentID={2}", this.Student.StudentID, student.StudentID, Parent.Student.StudentID));
			Student studentA = null;
			Student studentB = null;
			if (studentComparer.Compare(this.Student, parentNode.Student) < 0)
			{
				studentA = this.Student;
				studentB = parentNode.Student;
			}
			else
			{
				studentA = parentNode.Student;
				studentB = this.Student;
			}	

			if ((studentComparer.Compare(studentA, student) < 0) && (studentComparer.Compare(student, studentB) < 0))
			{
				StudentNode insertedNode = new StudentNode(student, parentNode);
				if (parentNode.Left == this)
				{
					Console.WriteLine(String.Format("Inserting {0} between {1} and {2} (left side)", student.StudentID, studentA.StudentID, studentB.StudentID));
					parentNode.Left = insertedNode;
					insertedNode.Left = this;
				}
				else
				{
					Console.WriteLine(String.Format("Inserting {0} between {1} and {2} (right side)", student.StudentID, studentA.StudentID, studentB.StudentID));
					parentNode.Right = insertedNode;
					insertedNode.Right = this;
				}

				this.Parent = insertedNode;
			}
			else if (studentComparer.Compare(student, Student) < 0)
			{
				Console.WriteLine(String.Format("Inserting {0} to the left of {1}", student.StudentID, this.Student.StudentID));
				if (this.Left == null)
				{
					this.Left = new StudentNode(student, this);
				}
				else
				{
					this.Left.Insert(student, studentComparer, this);
				}
			}
			else
			{
				Console.WriteLine(String.Format("Inserting {0} to the right of {1}", student.StudentID, this.Student.StudentID));
				if (this.Right == null)
				{
					this.Right = new StudentNode(student, this);
				}
				else
				{
					this.Right.Insert(student, studentComparer, this);
				}
			}
		}

		public void Add(Student student, StudentComparer studentComparer)
		{
			Console.WriteLine(String.Format("StudentNode::Add: this.StudentID={0}; New Node StudentID={1}", Student.StudentID, student.StudentID));
			if (student.StudentID < m_student.StudentID)
			{
				if (m_left == null)
				{
					m_left = new StudentNode(student, this);
				}
				else
				{
					m_left.Insert(student, studentComparer, this);
				}
			}
			else 
			{
				if (m_right == null)
				{
					m_right = new StudentNode(student, this);
				}
				else
				{
					m_right.Insert(student, studentComparer, this);
				}
			}
		}

		public void Remove(Student student, Student parent) 
		{
			throw new NotImplementedException();
		}

		public Student Student
		{
			get { return m_student; }
		}

		public StudentNode Left
		{
			get { return m_left; }
			set { m_left = value; }
		}

		public StudentNode Right
		{
			get { return m_right; }
			set { m_right = value; }
		}

		public StudentNode Parent
		{
			get { return m_parent; }
			set { m_parent = value; }
		}

		private Student m_student;

		private StudentNode m_left;
		private StudentNode m_right;
		private StudentNode m_parent;
	}

	public class StudentTree : IEnumerable<Student>
	{
		public StudentTree()
		{
			m_studentNodeRoot = null;
			m_studentNodeCurrent = null;
		}

		public void Add(Student student)
		{
			if (m_studentNodeRoot == null)
			{
				m_studentNodeRoot = new StudentNode(student);
			}
			else
			{
				m_studentNodeRoot.Add(student, m_studentComparer);
			}
		}

		public void PruneBranch(StudentNode node)
		{
			if (node != null)
			{
				PruneBranch(node.Left);
				PruneBranch(node.Right);
				node.Left = null;
				node.Right = null;
			}
		}

		public void Clear()
		{
			StudentNode nodeCurrent = m_studentNodeRoot;
			if (nodeCurrent != null)
			{
				PruneBranch(nodeCurrent.Left);
				nodeCurrent.Left = null;

				PruneBranch(nodeCurrent.Right);
				nodeCurrent.Right = null;
			}

			m_studentNodeRoot = null;
		}

		public StudentNode Reset()
		{
			StudentNode node = m_studentNodeRoot;
			while ((node != null) && (node.Left != null))
			{
				node = node.Left;
			}

			m_studentNodeCurrent = node;
			return node;
		}

		IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
		{
			return new StudentTreeEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StudentTreeEnumerator(this);
		}

		public StudentComparer m_studentComparer = null;

		public StudentNode Root => m_studentNodeRoot;
		public StudentNode CurrentNode => m_studentNodeCurrent;

		private StudentNode m_studentNodeRoot;
		private StudentNode m_studentNodeCurrent;
	}

	public class StudentTreeEnumerator : IEnumerator<Student>
	{
		public StudentTreeEnumerator(StudentTree studentTree)
		{
			m_studentTree = studentTree;
			m_studentNodeCurrent = studentTree.Reset();
		}

		public Student Current => (m_studentNodeCurrent != null) ? m_studentNodeCurrent.Student : null;

		object IEnumerator.Current => (m_studentNodeCurrent != null) ? m_studentNodeCurrent.Student : null;

		void IDisposable.Dispose()
		{
			throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			bool bRetVal = true;
			if (m_studentNodeCurrent.Right != null)
			{
				m_studentNodeCurrent = m_studentNodeCurrent.Right;
				while (m_studentNodeCurrent.Left != null)
				{
					m_stack.Push(m_studentNodeCurrent);
					m_studentNodeCurrent = m_studentNodeCurrent.Left;
				}
			}
			else if (m_stack.Count > 0)
			{
				m_studentNodeCurrent = m_stack.Pop();
			}
			else
			{
				m_studentNodeCurrent = null;
				bRetVal = false;
			}

			return bRetVal;
		}

		public void Reset()
		{
			m_stack.Clear();
			m_studentNodeCurrent = null;
			StudentNode node = m_studentTree.Root;
			while (node != null)
			{
				m_stack.Push(node);
				node = node.Left;
			}

			if (m_stack.Count > 0)
			{
				m_studentNodeCurrent = m_stack.Pop();
			}
		}

		private Stack<StudentNode> m_stack = new Stack<StudentNode>();
		private StudentTree m_studentTree;
		private StudentNode m_studentNodeCurrent;
	}
}
