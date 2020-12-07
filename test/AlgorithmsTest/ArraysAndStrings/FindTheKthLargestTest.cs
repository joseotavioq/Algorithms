using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class FindTheKthLargestTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 2;

            int result = new FindTheKthLargest().FirstTry(nums, k);

            Assert.Equal(5, result);
        }

        [Fact]
        public void FirstTry_With_Negative_Values()
        {
            int[] nums = new int[] { 30, -40, -20, -10, 40, 0, 10, 5 };
            int k = 1;

            int result = new FindTheKthLargest().FirstTry(nums, k);

            Assert.Equal(40, result);
        }

        [Fact]
        public void FirstTry_Already_Sorted_Array()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = 5;

            int result = new FindTheKthLargest().FirstTry(nums, k);

            Assert.Equal(4, result);
        }

        [Fact]
        public void FirstTry_Sort_Inverted_Array()
        {
            int[] nums = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            int k = 3;

            int result = new FindTheKthLargest().FirstTry(nums, k);

            Assert.Equal(5, result);
        }
    }
}