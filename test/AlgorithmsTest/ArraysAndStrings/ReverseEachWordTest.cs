using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ReverseEachWordTest
    {
        [Fact]
        public void FirstTry_Send_Empty_String()
        {
            string myEntireString = string.Empty;

            string returnedValue = new ReverseEachWord().FirstTry(myEntireString);

            Assert.Equal(string.Empty, returnedValue);
        }

        [Fact]
        public void FirstTry_Send_Null()
        {
            string myEntireString = null;

            string returnedValue = new ReverseEachWord().FirstTry(myEntireString);

            Assert.Equal(string.Empty, returnedValue);
        }

        [Fact]
        public void FirstTry_Reverse_Small_Words()
        {
            string myEntireString = "ba ba";

            string returnedValue = new ReverseEachWord().FirstTry(myEntireString);

            Assert.Equal("ab ab", returnedValue);
        }

        [Fact]
        public void FirstTry_Reverse_Words()
        {
            string myEntireString = "The quick brown foxes jump over the lazy fuzzy hounds";

            string returnedValue = new ReverseEachWord().FirstTry(myEntireString);

            Assert.Equal("ehT kciuq nworb sexof pmuj revo eht yzal yzzuf sdnuoh", returnedValue);
        }

        [Fact]
        public void FirstTry_Reverse_Words_And_Numbers()
        {
            string myEntireString = "The quick 123 brown foxes jump over the lazy fuzzy hounds";

            string returnedValue = new ReverseEachWord().FirstTry(myEntireString);

            Assert.Equal("ehT kciuq 321 nworb sexof pmuj revo eht yzal yzzuf sdnuoh", returnedValue);
        }
    }
}