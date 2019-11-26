using Algorithms.LinkedLists;
using Xunit;

namespace AlgorithmsTest.LinkedLists
{
    public class SumListsTest
    {
        [Fact]
        public void Sum_Two_Lists_617_And_295_Is_912()
        {
            var first = new MyLinkedList<int>(7);
            first.Append(1);
            first.Append(6);

            var second = new MyLinkedList<int>(5);
            second.Append(9);
            second.Append(2);

            var result = new SumLists().FirstTry(first, second);

            Assert.Equal(2, result.Value);
            Assert.Equal(1, result.Next.Value);
            Assert.Equal(9, result.Next.Next.Value);
            Assert.Null(result.Next.Next.Next);
        }

        [Fact]
        public void Sum_Two_Lists_999_And_999_Is_1998()
        {
            var first = new MyLinkedList<int>(9);
            first.Append(9);
            first.Append(9);

            var second = new MyLinkedList<int>(9);
            second.Append(9);
            second.Append(9);

            var result = new SumLists().FirstTry(first, second);

            Assert.Equal(8, result.Value);
            Assert.Equal(9, result.Next.Value);
            Assert.Equal(9, result.Next.Next.Value);
            Assert.Equal(1, result.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next);
        }
    }
}