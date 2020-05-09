using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class QuickSortTest
    {
        [Fact]
        public void FirstTry()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = new QuickSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }
    }
}