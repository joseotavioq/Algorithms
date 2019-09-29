using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class CheckPermutationTest
    {
        [Fact]
        public void FirstTry_One_String_Is_Permutation_Of_The_Other()
        {
            string first = "abcdefgh";
            string second = "fdceagbh";

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_One_String_Is_Not_Permutation_Of_The_Other_Because_Has_a_Different_Char()
        {
            string first = "abcdefgh";
            string second = "fdcmagbh";

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_One_String_Is_Not_Permutation_Of_The_Other()
        {
            string first = "abcddfgh";
            string second = "abcdcfgh";

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Qty_Of_Elements_Are_Different()
        {
            string first = "abcdefgh";
            string second = "abcdefg";

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_First_Parameter_Is_Null()
        {
            string first = null;
            string second = "abcdefgh";

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Second_Parameter_Is_Null()
        {
            string first = "abcdefgh";
            string second = null;

            bool result = new CheckPermutation().FirstTry(first, second);

            Assert.False(result);
        }
    }
}