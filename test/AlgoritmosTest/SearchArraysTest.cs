using Algoritmos;
using Xunit;

namespace AlgoritmosTest
{
    public class SearchArraysTest
    {
        [Fact]
        public void Maximum_Element_In_An_Array()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 1, 7, 2, 3 };
            var maxValue = SearchArray.MaximumElement(listOfNumbers);

            Assert.Equal(8, maxValue);
        }

        [Fact]
        public void Has_Duplicate_Element_In_An_Array()
        {
            int[] listOfNumbers = new int[] { 5, 4, 6, 8, 2, 1, 7, 2, 3 };
            var hasDuplicate = SearchArray.HasDuplicateElement(listOfNumbers);

            Assert.True(hasDuplicate);
        }

        [Fact]
        public void Binary_Search_Linear()
        {
            int[] listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var found = SearchArray.BinarySearch_Linear(listOfNumbers, 7);

            Assert.True(found);
        }

        [Fact]
        public void Binary_Search_Recursive()
        {
            int[] listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var found = SearchArray.BinarySearch_Recursive(listOfNumbers, 7, 0, listOfNumbers.Length);

            Assert.True(found);
        }
    }
}