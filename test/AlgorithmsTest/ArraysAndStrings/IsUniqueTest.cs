using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class IsUniqueTest
    {
        [Fact]
        public void The_String_Has_All_Unique_Characters_First_True()
        {
            string myString = "abcdefgh";

            bool result = new IsUnique().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void The_String_Has_All_Unique_Characters_First_False()
        {
            string myString = "abcdebfgh";

            bool result = new IsUnique().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void The_String_Has_All_Unique_Characters_Second_True()
        {
            string myString = "abcdefgh";

            bool result = new IsUnique().SecondTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void The_String_Has_All_Unique_Characters_Second_False()
        {
            string myString = "abcdebfgh";

            bool result = new IsUnique().SecondTry(myString);

            Assert.False(result);
        }
    }
}