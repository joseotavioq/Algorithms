using Xunit;
using Algorithms.Logic;

namespace AlgorithmsTest.Logic
{
    public class MultiplyTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int x = 5;
            int y = 4;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(20, result);
        }

        [Fact]
        public void FirstTry_Basic_But_Inverting_Parameters_Test()
        {
            int x = 4;
            int y = 5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(20, result);
        }

        [Fact]
        public void FirstTry_Just_The_First_Parameter_Is_Negative_Test()
        {
            int x = -4;
            int y = 5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(-20, result);
        }

        [Fact]
        public void FirstTry_Just_The_Second_Parameter_Is_Negative_Test()
        {
            int x = 4;
            int y = -5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(-20, result);
        }

        [Fact]
        public void FirstTry_Both_Parameters_Are_Negative_Test()
        {
            int x = -4;
            int y = -5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(20, result);
        }

        [Fact]
        public void FirstTry_Just_The_First_Parameter_Is_Zero_Test()
        {
            int x = 0;
            int y = 5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(0, result);
        }

        [Fact]
        public void FirstTry_Just_The_Second_Parameter_Is_Zero_Test()
        {
            int x = 4;
            int y = 0;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(0, result);
        }
        [Fact]
        public void FirstTry_The_First_Parameter_Is_Zero_And_The_Second_Is_Negative_Test()
        {
            int x = 0;
            int y = -5;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(0, result);
        }

        [Fact]
        public void FirstTry_The_First_Parameter_Is_Negative_And_The_Second_Is_Zero_Test()
        {
            int x = -4;
            int y = 0;

            int result = new Multiply().FirstTry(x, y);

            Assert.Equal(0, result);
        }
    }
}