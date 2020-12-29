using System.Collections;
using System.Collections.Generic;


namespace Structures
{
    public class Queue<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Capacity { get; set; }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (Head == null)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;
            Capacity++;
        }

        public Node<T> GetNode(int id)
        {
            Node<T> current = Head;
            int s = 0;
            while (s < id)
            {
                current = current.Next;
                s++;
            }

            return current;
        }

        public void Remove(int id)
        {
            Node<T> current = Head;
            int s = 0;
            while (s < id - 1)
            {
                current = current.Next;
                s++;
            }

            if (s == 0)
            {
                if (Head.Next != null)
                    Head = Head.Next;
                else
                    Head = null;
            }

            else if (s == Capacity - 1)
            {
                current.Next = null;
                Tail = null;
            }
            else
                current.Next = current.Next.Next;
            Capacity--;
        }

        public bool IsEmptyList()
        {
            return Capacity == 0;
        }

        public void MakeClear()
        {
            Head = null;
            Tail = null;
            Capacity = 0;
        }

        public void AddToHead(T child)
        {
            Node<T> node = new Node<T>(child);
            node.Next = Head;
            Head = node;
            if (Capacity == 0)
                Tail = Head;
            Capacity++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}