using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class IsUniqueTest
    {
        [Fact]
        public void FirstTry_The_String_Has_All_Unique_Characters()
        {
            string myString = "abcdefgh";

            bool result = new IsUnique().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_The_String_Has_A_Duplicate_Character()
        {
            string myString = "abcdebfgh";

            bool result = new IsUnique().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void SecondTry_The_String_Has_All_Unique_Characters()
        {
            string myString = "abcdefgh";

            bool result = new IsUnique().SecondTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void SecondTry_The_String_Has_A_Duplicate_Character()
        {
            string myString = "abcdebfgh";

            bool result = new IsUnique().SecondTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void MyTry_Vafzmora_The_String_Has_All_Unique_Characters()
        {
            string myString = "abcdefgh";

            bool result = new IsUnique().MyTry_Vafzmora(myString);

            Assert.True(result);
        }

        [Fact]
        public void MyTry_Vafzmora_The_String_Has_A_Duplicate_Character()
        {
            string myString = "abcdebfgh";

            bool result = new IsUnique().MyTry_Vafzmora(myString);

            Assert.False(result);
        }
    }
}