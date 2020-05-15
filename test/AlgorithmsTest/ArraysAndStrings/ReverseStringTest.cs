using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ReverseStringTest
    {
        [Fact]
        public void FirstTry_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().FirstTry(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void FirstTry_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().FirstTry(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().InJustOneLine(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine2_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().InJustOneLine2(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void InJustOneLine2_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().InJustOneLine2(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Fast_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Fast(myEntireString);

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
        public void Vafzamora_Fast1_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Vafzamora_Fast1(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Vafzamora_Fast1_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().Vafzamora_Fast1(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Vafzamora_Fast2_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Vafzamora_Fast2(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Vafzamora_Fast2_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().Vafzamora_Fast2(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Vafzamora_Obvious_With_Even_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms!";

            string returnedValue = new ReverseString().Vafzamora_Obvious(myEntireString);

            Assert.Equal("!smhtiroglA gninraeL", returnedValue);
        }

        [Fact]
        public void Vafzamora_Obvious_With_Odd_Parameter_Qty()
        {
            string myEntireString = "Learning Algorithms";

            string returnedValue = new ReverseString().Vafzamora_Obvious(myEntireString);

            Assert.Equal("smhtiroglA gninraeL", returnedValue);
        }
    }
}