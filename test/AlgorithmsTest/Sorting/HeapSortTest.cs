using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class HeapSortTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int[] listOfNumbers = new int[] { 10, 6, 7, 5, 15, 17, 12 };

            var sortedArray = new HeapSort().FirstTry(listOfNumbers);

            Assert.Equal(new int[] { 5, 6, 7, 10, 12, 15, 17 }, sortedArray);
        }

        [Fact]
        public void FirstTry_Basic_With_Odd_Size_Test()
        {
            int[] listOfNumbers = new int[] { 6, 4, 9, 2, 1, 5, 7, 3, 8 };

            var sortedArray = new HeapSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }

        [Fact]
        public void FirstTry_Basic_With_Even_Size_Test()
        {
            int[] listOfNumbers = new int[] { 6, 4, 2, 1, 5, 7, 3, 8 };

            var sortedArray = new HeapSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, sortedArray[i - 1]);
        }
    }
}