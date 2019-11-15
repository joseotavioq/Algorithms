using Algorithms.HashTables;
using Xunit;

namespace AlgorithmsTest.HashTables
{
    public class RecurringNumberTest
    {
        [Fact]
        public void FirstTry_Return_Number_2()
        {
            int[] numbers = new int[] { 2, 3, 1, 5, 2, 4, 1 };

            int result = new RecurringNumber().FirstTry(numbers);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FirstTry_No_Recurring_Number()
        {
            int[] numbers = new int[] { 2, 3, 1, 5 };

            int result = new RecurringNumber().FirstTry(numbers);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void SecondTry_Return_Number_2()
        {
            int[] numbers = new int[] { 2, 3, 1, 5, 2, 4, 1 };

            int result = new RecurringNumber().SecondTry(numbers);

            Assert.Equal(2, result);
        }

        [Fact]
        public void SecondTry_No_Recurring_Number()
        {
            int[] numbers = new int[] { 2, 3, 1, 5 };

            int result = new RecurringNumber().SecondTry(numbers);

            Assert.Equal(-1, result);
        }
    }
}