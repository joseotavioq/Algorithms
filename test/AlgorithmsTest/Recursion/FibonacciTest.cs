using Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Recursion
{
    public class FibonacciTest
    {
        [Fact]
        public void Recursive_Index_of_10()
        {
            var result = new Fibonacci().Recursive(10);

            Assert.Equal(55, result);
        }

        [Fact]
        public void Recursive_Index_of_7()
        {
            var result = new Fibonacci().Recursive(7);

            Assert.Equal(13, result);
        }

        [Fact]
        public void Recursive_Index_of_3()
        {
            var result = new Fibonacci().Recursive(3);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Recursive_Index_of_2()
        {
            var result = new Fibonacci().Recursive(2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Recursive_Index_of_1()
        {
            var result = new Fibonacci().Recursive(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Recursive_Index_of_0()
        {
            var result = new Fibonacci().Recursive(0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Iterative_Index_of_10()
        {
            var result = new Fibonacci().Iterative(10);

            Assert.Equal(55, result);
        }

        [Fact]
        public void Iterative_Index_of_7()
        {
            var result = new Fibonacci().Iterative(7);

            Assert.Equal(13, result);
        }

        [Fact]
        public void Iterative_Index_of_3()
        {
            var result = new Fibonacci().Iterative(3);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Iterative_Index_of_2()
        {
            var result = new Fibonacci().Iterative(2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Iterative_Index_of_1()
        {
            var result = new Fibonacci().Iterative(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Iterative_Index_of_0()
        {
            var result = new Fibonacci().Iterative(0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_10()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(10);

            Assert.Equal(55, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_7()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(7);

            Assert.Equal(13, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_3()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(3);

            Assert.Equal(2, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_2()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_1()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void IterativeWithoutMemoryAllocation_Index_of_0()
        {
            var result = new Fibonacci().IterativeWithoutMemoryAllocation(0);

            Assert.Equal(0, result);
        }
    }
}