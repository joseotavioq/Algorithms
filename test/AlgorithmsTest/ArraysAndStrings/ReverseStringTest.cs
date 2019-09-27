using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ArraysAndStringsTest
    {
        [Fact]
        public void Reverse_The_Entire_String()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().FirstTry(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Reverse_The_Entire_String_OneLine()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Reverse_The_Entire_String_OneLine2()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine2(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Reverse_The_Entire_String_Fast_With_Odd()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().Fast(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Reverse_The_Entire_String_Fast_With_Even()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Fast(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }
    }
}
