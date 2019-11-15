using Algorithms.Olders;
using Xunit;

namespace AlgorithmsTest.Olders
{
    public class HashMapTest
    {
        [Fact]
        public void Find_Unique_Words_And_Their_Count()
        {
            string[] listOfWords = new string[] { "pen", "pencil", "eraser", "pen" };

            var hashMap = HashMap.FindUniqueWordsAndTheirCount(listOfWords);

            Assert.Equal(2, hashMap["pen"]);
            Assert.Equal(1, hashMap["pencil"]);
            Assert.Equal(1, hashMap["eraser"]);
        }
    }
}