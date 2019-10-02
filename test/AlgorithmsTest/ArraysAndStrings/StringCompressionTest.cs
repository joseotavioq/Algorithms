using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class StringCompressionTest
    {
        #region FirstTry
        [Fact]
        public void FirstTry_Given_String_aabcccccaaa_returns_a2b1c5a3()
        {
            string input = "aabcccccaaa";

            string result = new StringCompression().FirstTry(input);

            Assert.Equal("a2b1c5a3", result);
        }

        [Fact]
        public void FirstTry_Given_String_abc_returns_abc()
        {
            string input = "abc";

            string result = new StringCompression().FirstTry(input);

            Assert.Equal("abc", result);
        }
        #endregion

        #region SecondTry
        [Fact]
        public void SecondTry_Given_String_aabcccccaaa_returns_a2b1c5a3()
        {
            string input = "aabcccccaaa";

            string result = new StringCompression().SecondTry(input);

            Assert.Equal("a2b1c5a3", result);
        }

        [Fact]
        public void SecondTry_Given_String_abc_returns_abc()
        {
            string input = "abc";

            string result = new StringCompression().SecondTry(input);

            Assert.Equal("abc", result);
        }
        #endregion

        #region ThirdTry
        [Fact]
        public void ThirdTry_Given_String_aabcccccaaa_returns_a2b1c5a3()
        {
            string input = "aabcccccaaa";

            string result = new StringCompression().ThirdTry(input);

            Assert.Equal("a2b1c5a3", result);
        }

        [Fact]
        public void ThirdTry_Given_String_abc_returns_abc()
        {
            string input = "abc";

            string result = new StringCompression().ThirdTry(input);

            Assert.Equal("abc", result);
        }
        #endregion
    }
}