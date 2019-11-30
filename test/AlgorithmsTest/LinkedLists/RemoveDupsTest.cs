using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class RemoveDupsTest
    {
        [Fact]
        public void FirstTry_Remove_Value_1_Duplicated()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 7, 4, 1, 5, 6 }).Head;

            var result = new RemoveDups().FirstTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(5, result.Next.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void FirstTry_Remove_Value_1_Duplicated_In_A_Sequence()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 7, 4, 1, 1, 6 }).Head;

            var result = new RemoveDups().FirstTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }

        [Fact]
        public void SecondTry_Remove_Value_1_Duplicated()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 7, 4, 1, 5, 6 }).Head;

            var result = new RemoveDups().SecondTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(5, result.Next.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next.Next);
        }

        [Fact]
        public void SecondTry_Remove_Value_1_Duplicated_In_A_Sequence()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 7, 4, 1, 1, 6 }).Head;

            var result = new RemoveDups().SecondTry(head);

            Assert.Equal(1, result.Value);
            Assert.Equal(7, result.Next.Value);
            Assert.Equal(4, result.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }
    }
}