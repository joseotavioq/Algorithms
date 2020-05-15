using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class ReturnKthToLastTest
    {
        [Fact]
        public void FirstTry_Return_The_1st_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FirstTry(head, 1);

            Assert.Equal(6, node.Value);
        }

        [Fact]
        public void FirstTry_Return_The_2nd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FirstTry(head, 2);

            Assert.Equal(5, node.Value);
        }

        [Fact]
        public void FirstTry_Return_The_3rd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FirstTry(head, 3);

            Assert.Equal(4, node.Value);
        }

        [Fact]
        public void FirstTry_Return_The_1st_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FirstTry(head, 6);

            Assert.Equal(1, node.Value);
        }

        [Fact]
        public void FirstTry_Node_Not_Found()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FirstTry(head, 7);

            Assert.Null(node);
        }

        [Fact]
        public void SecondTry_Return_The_1st_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().SecondTry(head, 1);

            Assert.Equal(6, node.Value);
        }

        [Fact]
        public void SecondTry_Return_The_2nd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().SecondTry(head, 2);

            Assert.Equal(5, node.Value);
        }

        [Fact]
        public void SecondTry_Return_The_3rd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().SecondTry(head, 3);

            Assert.Equal(4, node.Value);
        }

        [Fact]
        public void SecondTry_Return_The_1st_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().SecondTry(head, 6);

            Assert.Equal(1, node.Value);
        }

        [Fact]
        public void SecondTry_Node_Not_Found()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().SecondTry(head, 7);

            Assert.Null(node);
        }

        [Fact]
        public void ThirdTry_Return_The_1st_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().ThirdTry(head, 1);

            Assert.Equal(6, node.Value);
        }

        [Fact]
        public void ThirdTry_Return_The_2nd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().ThirdTry(head, 2);

            Assert.Equal(5, node.Value);
        }

        [Fact]
        public void ThirdTry_Return_The_3rd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().ThirdTry(head, 3);

            Assert.Equal(4, node.Value);
        }

        [Fact]
        public void ThirdTry_Return_The_1st_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().ThirdTry(head, 6);

            Assert.Equal(1, node.Value);
        }

        [Fact]
        public void ThirdTry_Node_Not_Found()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().ThirdTry(head, 7);

            Assert.Null(node);
        }

        [Fact]
        public void FourthTry_Return_The_1st_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FourthTry(head, 1);

            Assert.Equal(6, node.Value);
        }

        [Fact]
        public void FourthTry_Return_The_2nd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FourthTry(head, 2);

            Assert.Equal(5, node.Value);
        }

        [Fact]
        public void FourthTry_Return_The_3rd_Last_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FourthTry(head, 3);

            Assert.Equal(4, node.Value);
        }

        [Fact]
        public void FourthTry_Return_The_1st_Node()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FourthTry(head, 6);

            Assert.Equal(1, node.Value);
        }

        [Fact]
        public void FourthTry_Node_Not_Found()
        {
            Node<int> head = MyLinkedList<int>.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }).Head;

            var node = new ReturnKthToLast().FourthTry(head, 7);

            Assert.Null(node);
        }
    }
}