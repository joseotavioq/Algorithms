using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
            Next = null;
        }

        public T Value { get; private set; }
        public Node<T> Next { get; set; }
    }
}
