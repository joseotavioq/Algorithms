using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class MergeSortedArrayTest
    {
        [Fact]
        public void FirstTry_Merged_Two_Sorted_Arrays()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void FirstTry_Merged_Two_Sorted_Arrays_Inverting_The_Parameters()
        {
            int[] x = new int[] { 4, 6, 29, 30 };
            int[] y = new int[] { 0, 3, 4, 31, 44, 49 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void FirstTry_First_Parameter_Is_Empty()
        {
            int[] x = new int[0];
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 4, 6, 29, 30 }, z);
        }

        [Fact]
        public void FirstTry_Second_Parameter_Is_Empty()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[0];

            int[] z = new MergeSortedArray().FirstTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 31, 44, 49 }, z);
        }

        [Fact]
        public void SecondTry_Merged_Two_Sorted_Arrays()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void SecondTry_Merged_Two_Sorted_Arrays_Inverting_The_Parameters()
        {
            int[] x = new int[] { 4, 6, 29, 30 };
            int[] y = new int[] { 0, 3, 4, 31, 44, 49 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 4, 6, 29, 30, 31, 44, 49 }, z);
        }

        [Fact]
        public void SecondTry_First_Parameter_Is_Empty()
        {
            int[] x = new int[0];
            int[] y = new int[] { 4, 6, 29, 30 };

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 4, 6, 29, 30 }, z);
        }

        [Fact]
        public void SecondTry_Second_Parameter_Is_Empty()
        {
            int[] x = new int[] { 0, 3, 4, 31, 44, 49 };
            int[] y = new int[0];

            int[] z = new MergeSortedArray().SecondTry(x, y);

            Assert.Equal(new int[] { 0, 3, 4, 31, 44, 49 }, z);
        }
    }
}