using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ArraysAndStringsTest
    {
        [Fact]
        public void FirstTry_Reverse_The_String()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().FirstTry(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine_Reverse_The_String()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine2_Reverse_The_String()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine2(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Fast_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().Fast(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Fast_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Fast(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }
    }
}
