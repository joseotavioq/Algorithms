using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class PrintWordWithSeparatorTest
    {
        [Fact]
        public void Print_Hello_Word()
        {
            string word = "hello";

            var result = new PrintWordWithSeparator().Print(word, ',', 2);

            string expectedResult = @"h,e,l,l,o--^------";

            Assert.Equal(expectedResult, result);
        }
    }
}