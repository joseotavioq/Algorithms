using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedLists
{
    public class MyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Length { get; private set; }

        public MyLinkedList(T value)
        {
            Head = new Node<T>(value);
            Tail = Head;
            Length = 1;
        }

        public void Append(T value)
        {
            var newNode = new Node<T>(value);
            Tail.Next = newNode;
            Tail = newNode;
            Length++;
        }
    }
}
