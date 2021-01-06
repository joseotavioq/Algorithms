using Algorithms.ArraysAndStrings;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class CandyCrushTest
    {
        [Fact]
        public void Removing_Three_Combinations()
        {
            List<int> numbers = new List<int>() { 4, 2, 1, 1, 1, 2, 3, 3, 3, 2, 2, 2 };

            new CandyCrush().FirstTry(numbers);

            Assert.Single(numbers);
            Assert.Equal(4, numbers[0]);
        }

        [Fact]
        public void Removing_Two_Combinations()
        {
            List<int> numbers = new List<int>() { 4, 2, 1, 1, 1, 2, 3, 3, 3 };

            new CandyCrush().FirstTry(numbers);

            Assert.Equal(3, numbers.Count);
            Assert.Equal(4, numbers[0]);
            Assert.Equal(2, numbers[1]);
            Assert.Equal(2, numbers[2]);
        }
    }
}