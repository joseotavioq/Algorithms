using Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Recursion
{
    public class TripleStepTest
    {
        [Fact]
        public void Steps_Number_4()
        {
            var result = new TripleStep().Recursive(4);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Steps_Number_7()
        {
            var result = new TripleStep().Recursive(7);

            Assert.Equal(44, result);
        }
    }
}