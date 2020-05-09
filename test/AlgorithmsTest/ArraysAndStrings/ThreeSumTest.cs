using Algorithms.ArraysAndStrings;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ThreeSumTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int[] nums = new int[] { 30, -40, -20, -10, 40, 0, 10, 5 };

            List<int[]> result = new ThreeSum().FirstTry(nums);

            Assert.Equal(4, result.Count);
        }

        [Fact]
        public void FirstTry_Null_Test()
        {
            int[] nums = null;

            List<int[]> result = new ThreeSum().FirstTry(nums);

            Assert.Empty(result);
        }
    }
}