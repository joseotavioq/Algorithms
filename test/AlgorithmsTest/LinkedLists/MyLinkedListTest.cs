using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class MyLinkedListTest
    {
        [Fact]
        public void Create_My_Linked_List()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Null(myLinkedList.Head.Next);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(1, myLinkedList.Length);
        }

        [Fact]
        public void Append_An_Element()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Append(5);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next);
            Assert.Equal(5, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void Append_Two_Elements()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Append(5);
            myLinkedList.Append(16);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(3, myLinkedList.Length);
        }

        [Fact]
        public void Prepend_An_Element_In_A_New_MyLinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Prepend(1);

            Assert.Equal(1, myLinkedList.Head.Value);
            Assert.NotNull(myLinkedList.Head.Next);
            Assert.Equal(10, myLinkedList.Head.Next.Value);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(2, myLinkedList.Length);
        }

        [Fact]
        public void Prepend_Two_Elements_In_A_New_MyLinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);

            myLinkedList.Prepend(1);
            myLinkedList.Prepend(2);

            Assert.Equal(2, myLinkedList.Head.Value);
            Assert.Equal(1, myLinkedList.Head.Next.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(10, myLinkedList.Tail.Value);
            Assert.Equal(3, myLinkedList.Length);
        }

        [Fact]
        public void Insert_An_Element_At_Index_2_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.Insert(2, 99);

            Assert.Equal(10, myLinkedList.Head.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Value);
            Assert.Equal(99, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(4, myLinkedList.Length);
        }

        [Fact]
        public void Insert_An_Element_At_Index_0_In_An_Existing_LinkedList()
        {
            var myLinkedList = new MyLinkedList<int>(10);
            myLinkedList.Append(5);
            myLinkedList.Append(16);

            myLinkedList.Insert(0, 99);

            Assert.Equal(99, myLinkedList.Head.Value);
            Assert.Equal(10, myLinkedList.Head.Next.Value);
            Assert.Equal(5, myLinkedList.Head.Next.Next.Value);
            Assert.Equal(16, myLinkedList.Head.Next.Next.Next.Value);
            Assert.Null(myLinkedList.Head.Next.Next.Next.Next);
            Assert.Equal(16, myLinkedList.Tail.Value);
            Assert.Equal(4, myLinkedList.Length);
        }
    }
}