using Algorithms.HashTables;
using Xunit;

namespace AlgorithmsTest.HashTables
{
    public class ContainsCommonItemTest
    {
        #region FirstTry
        [Fact]
        public void FirstTry_Return_True_Contains_A()
        {
            string[] arr1 = new string[] { "A", "B", "C", "D" };
            string[] arr2 = new string[] { "E", "F", "A", "H" };

            bool result = new  ContainsCommonItem().FirstTry(arr1, arr2);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Return_False()
        {
            string[] arr1 = new string[] { "A", "B", "C", "D" };
            string[] arr2 = new string[] { "E", "F", "G", "H" };

            bool result = new  ContainsCommonItem().FirstTry(arr1, arr2);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Return_False_With_Repeating_Values()
        {
            string[] arr1 = new string[] { "A", "A", "C", "D" };
            string[] arr2 = new string[] { "E", "E", "G", "H" };

            bool result = new ContainsCommonItem().FirstTry(arr1, arr2);

            Assert.False(result);
        }
        #endregion

        #region SecondTry
        [Fact]
        public void SecondTry_Return_True_Contains_A()
        {
            string[] arr1 = new string[] { "A", "B", "C", "D" };
            string[] arr2 = new string[] { "E", "F", "A", "H" };

            bool result = new ContainsCommonItem().SecondTry(arr1, arr2);

            Assert.True(result);
        }

        [Fact]
        public void SecondTry_Return_False()
        {
            string[] arr1 = new string[] { "A", "B", "C", "D" };
            string[] arr2 = new string[] { "E", "F", "G", "H" };

            bool result = new ContainsCommonItem().SecondTry(arr1, arr2);

            Assert.False(result);
        }

        [Fact]
        public void SecondTry_Return_False_With_Repeating_Values()
        {
            string[] arr1 = new string[] { "A", "A", "C", "D" };
            string[] arr2 = new string[] { "E", "E", "G", "H" };

            bool result = new ContainsCommonItem().SecondTry(arr1, arr2);

            Assert.False(result);
        }
        #endregion
    }
}