using Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Recursion
{
    public class FactorialTest
    {
        [Fact]
        public void Iterative_Factorial_of_10()
        {
            var result = new Factorial().Iterative(10);

            Assert.Equal(3628800, result);
        }

        [Fact]
        public void Iterative_Factorial_of_5()
        {
            var result = new Factorial().Iterative(5);

            Assert.Equal(120, result);
        }

        [Fact]
        public void Iterative_Factorial_of_2()
        {
            var result = new Factorial().Iterative(2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Iterative_Factorial_of_1()
        {
            var result = new Factorial().Iterative(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Iterative_Factorial_of_0()
        {
            var result = new Factorial().Iterative(0);

            Assert.Equal(1, result);
        }


        [Fact]
        public void Recursive_Factorial_of_10()
        {
            var result = new Factorial().Recursive(10);

            Assert.Equal(3628800, result);
        }

        [Fact]
        public void Recursive_Factorial_of_5()
        {
            var result = new Factorial().Recursive(5);

            Assert.Equal(120, result);
        }

        [Fact]
        public void Recursive_Factorial_of_2()
        {
            var result = new Factorial().Recursive(2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Recursive_Factorial_of_1()
        {
            var result = new Factorial().Recursive(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Recursive_Factorial_of_0()
        {
            var result = new Factorial().Recursive(0);

            Assert.Equal(1, result);
        }
    }
}