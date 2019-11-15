using Algorithms;
using Algorithms.Olders;
using Xunit;

namespace AlgorithmsTest.Olders
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
            //Can only (and should) be used on sorted data.
            int[] listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var found = SearchArray.BinarySearch_Linear(listOfNumbers, 7);

            Assert.True(found);
        }

        [Fact]
        public void Binary_Search_Recursive()
        {
            //Can only (and should) be used on sorted data.
            int[] listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var found = SearchArray.BinarySearch_Recursive(listOfNumbers, 7, 0, listOfNumbers.Length);

            Assert.True(found);
        }

        [Fact]
        public void Magic_Of_3()
        {
            var resultFor3 = SearchArray.MagicOf3(3);
            var resultFor13 = SearchArray.MagicOf3(13);

            Assert.Equal(3, resultFor3);
            Assert.Equal(6, resultFor13);
        }

        [Fact]
        public void Most_Frequent_Number_In_An_Array()
        {
            int[] listOfNumbers = new int[] { 1, 3, 4, 5, 2, 2, 3, 2 };

            var mostFrequent = SearchArray.MostFrequentNumber(listOfNumbers);

            Assert.Equal(2, mostFrequent);
        }

        [Fact]
        public void Count_Distance_For_Each_Value_In_An_Array()
        {
            string[] listOfItems = new string[] { "aa", "bb", "cc", "aa", "cc", "bb", "dd", "aa" };

            var result = SearchArray.CountDistance(listOfItems);

            Assert.Equal(3, result["aa"]);
            Assert.Equal(4, result["bb"]);
            Assert.Equal(2, result["cc"]);
        }

        [Fact]
        public void Count_Distance_For_Each_Value_In_An_Array_2()
        {
            string[] listOfItems = new string[] { "aa", "dd", "bb", "cc", "aa", "dd", "cc", "dd", "aa", "bb", "dd", "aa", "cc" };

            var result = SearchArray.CountDistance(listOfItems);

            Assert.Equal(3, result["aa"]);
            Assert.Equal(7, result["bb"]);
            Assert.Equal(3, result["cc"]);
        }
    }
}