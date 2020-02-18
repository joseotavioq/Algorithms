using Algorithms.ArraysAndStrings;
using Xunit;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class IsNumberTest
    {
        [Fact]
        public void FirstTry_Single_Zero()
        {
            string myString = "0";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Space_And_Decimal_Inside()
        {
            string myString = " 0.1 ";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Space_And_Decimal_Point()
        {
            string myString = " .";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Only_Letters()
        {
            string myString = "abc";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_A_Number_And_a_Letter()
        {
            string myString = "1 a";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_A_Number_With_Exponent()
        {
            string myString = "2e10";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_A_Negative_Number_With_Exponent_And_Spaces()
        {
            string myString = " -90e3   ";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_An_Incorrect_Exponent_And_Spaces()
        {
            string myString = " 1e";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_A_Correct_Exponent()
        {
            string myString = "2e0";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_An_Incorrect_Exponent()
        {
            string myString = "e3";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Another_Incorrect_Exponent()
        {
            string myString = ".e1";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Another_Incorrect_Exponent2()
        {
            string myString = "e11";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_A_Number_With_Negative_Exponent_And_Spaces()
        {
            string myString = " 6e-1";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_A_Number_With_Incorrect_Exponent_And_Spaces()
        {
            string myString = " 99e2.5 ";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_A_Number_Exponent()
        {
            string myString = "53.5e93";

            bool result = new IsNumber().FirstTry(myString);

            Assert.True(result);
        }

        [Fact]
        public void FirstTry_Two_Negative_Signs_And_Spaces()
        {
            string myString = " --6 ";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Two_Negative_Signs()
        {
            string myString = "-+3";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }

        [Fact]
        public void FirstTry_Incorrect_Number()
        {
            string myString = "95a54e53";

            bool result = new IsNumber().FirstTry(myString);

            Assert.False(result);
        }
    }
}