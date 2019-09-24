using Algoritmos;
using Xunit;

namespace AlgoritmosTest
{
    public class SortArrayTest
    {
        [Fact]
        public void Insertion_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = SortArray.Insertion(listOfNumbers);

            Assert.Equal(1, sortedArray[0]);
            Assert.Equal(8, sortedArray[sortedArray.Length - 1]);
        }

        [Fact]
        public void Selection_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = SortArray.Selection(listOfNumbers);

            Assert.Equal(1, sortedArray[0]);
            Assert.Equal(8, sortedArray[sortedArray.Length - 1]);
        }

        [Fact]
        public void Quick_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = SortArray.Quick(listOfNumbers, 0, listOfNumbers.Length - 1);

            Assert.Equal(1, sortedArray[0]);
            Assert.Equal(8, sortedArray[sortedArray.Length - 1]);
        }
        
        [Fact]
        public void Bubble_Sort()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };

            var sortedArray = SortArray.Bubble(listOfNumbers);

            Assert.Equal(1, sortedArray[0]);
            Assert.Equal(8, sortedArray[sortedArray.Length - 1]);
        }
    }
}