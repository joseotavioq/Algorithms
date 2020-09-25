using Xunit;
using Algorithms.Logic;

namespace AlgorithmsTest.Logic
{
    public class NumberSwapperTest
    {
        [Fact]
        public void Basic_Test()
        {
            int x = 10;
            int y = 8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void X_And_Y_Are_Negative_Numbers_Test()
        {
            int x = -10;
            int y = -8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void X_Is_Negative_Number_Test()
        {
            int x = -10;
            int y = 8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(8, x);
            Assert.Equal(-10, y);
        }

        [Fact]
        public void Y_Is_Negative_Number_Test()
        {
            int x = 10;
            int y = -8;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(-8, x);
            Assert.Equal(10, y);
        }

        [Fact]
        public void Equal_Numbers_Test()
        {
            int x = 10;
            int y = 10;

            (x, y) = new NumberSwapper().FirstTry(x, y);

            Assert.Equal(10, x);
            Assert.Equal(10, y);
        }
    }
}