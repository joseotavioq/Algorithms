using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class URLifyTest
    {
        [Fact]
        public void FirstTry_URLify_The_Parameter()
        {
            string input = "Mr John Smith    ";

            string output = new URLify().FirstTry(input);

            Assert.Equal("Mr%20John%20Smith", output);
        }
    }
}