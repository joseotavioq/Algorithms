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

            Assert.Equal(1, sortedArray[0]);
            Assert.Equal(8, sortedArray[sortedArray.Length - 1]);
        }
    }
}