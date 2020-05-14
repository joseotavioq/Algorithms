using Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Recursion
{
    public class TripleStepTest
    {
        [Fact]
        public void Recursive_Steps_Number_4()
        {
            var result = new TripleStep().Recursive(4);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Recursive_Steps_Number_7()
        {
            var result = new TripleStep().Recursive(7);

            Assert.Equal(44, result);
        }

        [Fact]
        public void Recursive_Steps_Number_10()
        {
            var result = new TripleStep().Recursive(10);

            Assert.Equal(274, result);
        }

        [Fact]
        public void Recursive_Steps_Number_30()
        {
            var result = new TripleStep().Recursive(30);

            Assert.Equal(53798080, result);
        }

        [Fact]
        public void RecursiveWithMemoization_Steps_Number_4()
        {
            var result = new TripleStep().RecursiveWithMemoization(4);

            Assert.Equal(7, result);
        }

        [Fact]
        public void RecursiveWithMemoization_Steps_Number_7()
        {
            var result = new TripleStep().RecursiveWithMemoization(7);

            Assert.Equal(44, result);
        }

        [Fact]
        public void RecursiveWithMemoization_Steps_Number_10()
        {
            var result = new TripleStep().RecursiveWithMemoization(10);

            Assert.Equal(274, result);
        }

        [Fact]
        public void RecursiveWithMemoization_Steps_Number_30()
        {
            var result = new TripleStep().RecursiveWithMemoization(30);

            Assert.Equal(53798080, result);
        }
    }
}