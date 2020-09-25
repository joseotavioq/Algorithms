using Xunit;
using Algorithms.Logic;

namespace AlgorithmsTest.Logic
{
    public class NumberSwapperTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int x = 10;
            int y = 8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void FirstTry_X_And_Y_Are_Negative_Numbers_Test()
        {
            int x = -10;
            int y = -8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void FirstTry_X_Is_Negative_Number_Test()
        {
            int x = -10;
            int y = 8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void FirstTry_Y_Is_Negative_Number_Test()
        {
            int x = 10;
            int y = -8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void FirstTry_Equal_Numbers_Test()
        {
            int x = 10;
            int y = 10;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(10, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void SecondTry_Basic_Test()
        {
            int x = 10;
            int y = 8;

            (x, y) = new NumberSwapper().SecondTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void SecondTry_X_And_Y_Are_Negative_Numbers_Test()
        {
            int x = -10;
            int y = -8;

            (x, y) = new NumberSwapper().SecondTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void SecondTry_X_Is_Negative_Number_Test()
        {
            int x = -10;
            int y = 8;

            (x, y) = new NumberSwapper().SecondTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void SecondTry_Y_Is_Negative_Number_Test()
        {
            int x = 10;
            int y = -8;

            (x, y) = new NumberSwapper().SecondTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void SecondTry_Equal_Numbers_Test()
        {
            int x = 10;
            int y = 10;

            (x, y) = new NumberSwapper().SecondTry(x, y);

            Assert.Equal(10, x);
            Assert.Equal(10, y);
        }
    }
}