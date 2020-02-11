using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ReverseStringPreservingSpacesTest
    {
        [Fact]
        public void FirstTry_Without_Space_Reverse_The_String()
        {
            string myEntireString = "ABCDEF";

            string returnedValue = new ReverseStringPreservingSpaces().FirstTry(myEntireString);

            Assert.Equal("FEDCBA", returnedValue);
        }

        [Fact]
        public void FirstTry_Medium_Input_Reverse_The_String()
        {
            string myEntireString = "A B CC D";

            string returnedValue = new ReverseStringPreservingSpaces().FirstTry(myEntireString);

            Assert.Equal("D C CB A", returnedValue);
        }

        [Fact]
        public void FirstTry_Large_Input_Reverse_The_String()
        {
            string myEntireString = "A BB CCC DDDD EEEEE FFFFFF";

            string returnedValue = new ReverseStringPreservingSpaces().FirstTry(myEntireString);

            Assert.Equal("F FF FFF EEEE EDDDD CCCBBA", returnedValue);
        }

        [Fact]
        public void SecondTry_Without_Space_Reverse_The_String()
        {
            string myEntireString = "ABCDEF";

            string returnedValue = new ReverseStringPreservingSpaces().SecondTry(myEntireString);

            Assert.Equal("FEDCBA", returnedValue);
        }

        [Fact]
        public void SecondTry_Medium_Input_Reverse_The_String()
        {
            string myEntireString = "A B CC D";

            string returnedValue = new ReverseStringPreservingSpaces().SecondTry(myEntireString);

            Assert.Equal("D C CB A", returnedValue);
        }

        [Fact]
        public void SecondTry_Large_Input_Reverse_The_String()
        {
            string myEntireString = "A BB CCC DDDD EEEEE FFFFFF";

            string returnedValue = new ReverseStringPreservingSpaces().SecondTry(myEntireString);

            Assert.Equal("F FF FFF EEEE EDDDD CCCBBA", returnedValue);
        }

        [Fact]
        public void ThirdTry_Without_Space_Reverse_The_String()
        {
            string myEntireString = "ABCDEF";

            string returnedValue = new ReverseStringPreservingSpaces().ThirdTry(myEntireString);

            Assert.Equal("FEDCBA", returnedValue);
        }

        [Fact]
        public void ThirdTry_Medium_Input_Reverse_The_String()
        {
            string myEntireString = "A B CC D";

            string returnedValue = new ReverseStringPreservingSpaces().ThirdTry(myEntireString);

            Assert.Equal("D C CB A", returnedValue);
        }

        [Fact]
        public void ThirdTry_Large_Input_Reverse_The_String()
        {
            string myEntireString = "A BB CCC DDDD EEEEE FFFFFF";

            string returnedValue = new ReverseStringPreservingSpaces().ThirdTry(myEntireString);

            Assert.Equal("F FF FFF EEEE EDDDD CCCBBA", returnedValue);
        }
    }
}