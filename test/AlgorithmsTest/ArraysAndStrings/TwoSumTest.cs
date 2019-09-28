using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class TwoSumTest
    {
        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_First()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_First_Unordered()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_First_Another_Parameter()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_First_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_First_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }


        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_First_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().FirstTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Second()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Second_Unordered()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Second_Another_Parameter()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Second_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_Second_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }


        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_Second_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().SecondTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Third()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Third_Unordered()
        {
            int[] nums = new int[] { 0, 4, 3, 0 };
            int target = 0;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 0, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Third_Another_Parameter()
        {
            int[] nums = new int[] { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Target_Third_When_Does_Not_Have_A_Match()
        {
            int[] nums = new int[] { 0, 1, 2, 5, 11, 15 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }

        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_Third_When_Passing_Null_Array()
        {
            int[] nums = null;
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }


        [Fact]
        public void Sum_Of_Two_Nums_Are_Equal_To_Null_Third_When_Passing_Less_Than_Two_Items()
        {
            int[] nums = new int[] { 9 };
            int target = 9;

            int[] result = new TwoSum().ThirdTry(nums, target);

            Assert.Null(result);
        }
    }
}