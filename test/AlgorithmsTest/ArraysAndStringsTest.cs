using Algorithms;
using Xunit;

namespace AlgorithmsTest
{
    public class ArraysAndStringsTest
    {
        [Fact]
        public void Reverse_The_Entire_String()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ArraysAndStrings().ReverseString(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Reverse_The_Entire_String_OneLine()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ArraysAndStrings().ReverseString_OneLine(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }
    }
}
