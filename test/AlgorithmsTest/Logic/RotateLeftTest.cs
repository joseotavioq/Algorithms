using Xunit;
using Algorithms.Logic;

namespace AlgorithmsTest.Logic
{
    public class RotateLeftTest
    {
        [Fact]
        public void FirstTry_Basic_Test()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotations = 4;

            array = new RotateLeft().FirstTry(array, numberOfRotations);

            Assert.Equal(new int[] { 5, 1, 2, 3, 4 }, array);
        }

        [Fact]
        public void FirstTry_Other_Test()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotations = 2;

            array = new RotateLeft().FirstTry(array, numberOfRotations);

            Assert.Equal(new int[] { 3, 4, 5, 1, 2 }, array);
        }

        [Fact]
        public void SecondTry_Basic_Test()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotations = 4;

            array = new RotateLeft().SecondTry(array, numberOfRotations);

            Assert.Equal(new int[] { 5, 1, 2, 3, 4 }, array);
        }

        [Fact]
        public void SecondTry_Other_Test()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int numberOfRotations = 2;

            array = new RotateLeft().SecondTry(array, numberOfRotations);

            Assert.Equal(new int[] { 3, 4, 5, 1, 2 }, array);
        }
    }
}