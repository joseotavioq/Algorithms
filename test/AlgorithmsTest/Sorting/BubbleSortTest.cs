using Algorithms.Sorting;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class BubbleSortTest
    {
        [Fact]
        public void FirstTry_Bubble_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = new BubbleSort().FirstTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, listOfNumbers[i - 1]);
        }

        [Fact]
        public void SecondTry_Bubble_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = new BubbleSort().SecondTry(listOfNumbers);

            for (int i = 1; i <= sortedArray.Length; i++)
                Assert.Equal(i, listOfNumbers[i - 1]);
        }
    }
}
