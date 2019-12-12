using System;

namespace cmd_algorithms.data_structures
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public LinkedList()
        {
            Head = new LinkedListNode<T>(default(T));
        }

        public LinkedList(T value)
        {
            if (Head is null)
                Head = new LinkedListNode<T>(default(T));
            Head.Next = new LinkedListNode<T>(value);
        }

        public LinkedListNode<T> Head { get; }
        public int Length { get; private set; }

        public LinkedListNode<T> Find(T t)
        {
            var node = Head.Next;
            while(node != null)
            {
                if (node.Value.CompareTo(t) == 0) return node;
                node = node.Next;
            }
            return null;
        }

        public LinkedListNode<T> Insert(int position, T newElement)
        {
            if (position < 1 || position > Length + 1)
                throw new IndexOutOfRangeException("position must be within the Length!");
            var node = Head;
            int i = 1;
            //find the node in that position
            while(node != null && i < position)
            {
                node = node.Next;
                ++i;
            }
            //add the node to that position
            var newNode = new LinkedListNode<T>(newElement);
            newNode.Next = node.Next;
            node.Next = newNode;

            Length++;

            return newNode;
        }

        public LinkedListNode<T> Find(int position)
        {
            if (position == 0)
                return Head;
            int i = 1;
            var node = Head;
            while(node != null && i < position)
            {
                node = node.Next;
                ++i;
            }
            return node;
        }
    }
}
