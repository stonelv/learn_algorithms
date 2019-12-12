using System;

namespace cmd_algorithms
{
    public class LinkedListNode<T> where T : IComparable<T>
    {
        public T Value { get; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}