using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Merge_Two_Sorted_Arrays_First()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_First_Inverted()
        {
            int[] x = new int[] { 4, 6, 29, 30 };
            int[] y = new int[] { 0, 3, 4, 31, 44, 49 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_First_With_First_Param_Empty()
        {
            int[] x = new int[0];
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 4, 6, 29, 30 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_First_With_Second_Param_Empty()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[0];

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 31, 44, 49 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_Second()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_Second_Inverted()
        {
            int[] x = new int[] { 4, 6, 29, 30 };
            int[] y = new int[] { 0, 3, 4, 31, 44, 49 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_Second_With_First_Param_Empty()
        {
            int[] x = new int[0];
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 4, 6, 29, 30 }, z);
        }

        [Fact]
        public void Merge_Two_Sorted_Arrays_Second_With_Second_Param_Empty()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[0];

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 31, 44, 49 }, z);
        }
    }
}