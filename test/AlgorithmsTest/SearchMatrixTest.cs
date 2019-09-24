using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class SearchMatrixTest
    {
        [Fact]
        public void Count_Negative_Integers_In_An_Ordered_Matrix()
        {
            int[,] matrixOfNumbersOrdered = new int[,] {
                    { -3, -2, -1, 1 },
                    { -2,  2,  3, 4 },
                    {  4,  5,  7, 8 }
            };

            var count = SearchMatrix.CountNegativeIntegers(matrixOfNumbersOrdered);

            Assert.Equal(4, count);
        }
    }
}