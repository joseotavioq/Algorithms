using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class TwoSumTest
    {
        [Fact]
        public void FirstTry_Sum_Of_Two_Nums_Are_Equal_To_Target()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void FirstTry_With_Unordered_Parameter()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void FirstTry_Sum_Of_Two_Nums_Are_Equal_To_Target_With_Other_Values()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void FirstTry_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void FirstTry_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void FirstTry_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void SecondTry_Sum_Of_Two_Nums_Are_Equal_To_Target()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void SecondTry_With_Unordered_Parameter()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void SecondTry_Sum_Of_Two_Nums_Are_Equal_To_Target_With_Other_Values()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void SecondTry_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void SecondTry_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void SecondTry_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void ThirdTry_Sum_Of_Two_Nums_Are_Equal_To_Target()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void ThirdTry_With_Unordered_Parameter()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void ThirdTry_Sum_Of_Two_Nums_Are_Equal_To_Target_With_Other_Values()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void ThirdTry_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void ThirdTry_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }


        [Fact]
        public void ThirdTry_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }
    }
}