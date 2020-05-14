using Algorithms.Recursion;
using Xunit;

namespace AlgorithmsTest.Recursion
{
    public class RobotGridTest
    {
        [Fact]
        public void FindPath()
        {
            bool[][] input = new bool[][] {
                new bool[] { true, true, false, true },
                new bool[] { true, true, true, true },
                new bool[] { false, true, false, true },
                new bool[] { true, true, true, true }
            };

            var result = new RobotGrid().FindPath(input);

            Assert.Equal(7, result.Count);
        }
    }
}