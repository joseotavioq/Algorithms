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
            Assert.Equal(new int[] { -40, 0, 40 }, result[0]);
            Assert.Equal(new int[] { -40, 10, 30 }, result[1]);
            Assert.Equal(new int[] { -40, 40, 0 }, result[2]);
            Assert.Equal(new int[] { -10, 0, 10 }, result[3]);
        }

        [Fact]
        public void FirstTry_Null_Test()
        {
            int[] nums = null;

            List<int[]> result = new ThreeSum().FirstTry(nums);

            Assert.Empty(result);
        }

        [Fact]
        public void SecondTry_Basic_Test()
        {
            int[] nums = new int[] { 30, -40, -20, -10, 40, 0, 10, 5 };

            List<int[]> result = new ThreeSum().SecondTry(nums);

            Assert.Equal(4, result.Count);
            Assert.Equal(new int[] { -40, 0, 40 }, result[0]);
            Assert.Equal(new int[] { -40, 10, 30 }, result[1]);
            Assert.Equal(new int[] { -40, 40, 0 }, result[2]);
            Assert.Equal(new int[] { -10, 0, 10 }, result[3]);
        }

        [Fact]
        public void SecondTry_Null_Test()
        {
            int[] nums = null;

            List<int[]> result = new ThreeSum().SecondTry(nums);

            Assert.Empty(result);
        }
    }
}