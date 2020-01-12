using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class MergeSortTest
    {
        [Fact]
        public void FirstTry_Sort_With_A_List_Totally_Unsorted()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 3, 2 };

            var sortedArray = new MergeSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }

        [Fact]
        public void FirstTry_Sort_With_A_List_Almost_Sorted()
        {
            int[] listOfNumbers = new int[] { 1, 2, 4, 3, 5, 7, 6, 8 };

            var sortedArray = new MergeSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }

        [Fact]
        public void FirstTry_Sort_With_A_List_In_Desc_Orders()
        {
            int[] listOfNumbers = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            var sortedArray = new MergeSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }
    }
}