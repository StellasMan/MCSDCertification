using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class GenStack<T>
    {
        public T Pop()
        {
            if (m_lnkLinkedList.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T tValue = m_lnkLinkedList.Last();
            m_lnkLinkedList.RemoveLast();
            return tValue;
        }

        public void Push(T value)
        {
            LinkedListNode<T> llNode = new LinkedListNode<T>(value);
            m_lnkLinkedList.AddLast(llNode);
        }

        public int Count
        {
            get { return m_lnkLinkedList.Count; }
        }

        private LinkedList<T> m_lnkLinkedList = new LinkedList<T>();
    }
}
