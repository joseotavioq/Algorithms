using Algorithms.Puzzle;
using Xunit;

namespace AlgorithmsTest.Puzzle
{
    public class BuildingPyramidTest
    {
        [Fact]
        public void Pyramid_With_6_Blocks()
        {
            int numberOfBlocks = 6;

            int height = new BuildingPyramid().GetHeight(numberOfBlocks);

            Assert.Equal(3, height);
        }

        [Fact]
        public void Pyramid_With_20_Blocks()
        {
            int numberOfBlocks = 20;

            int height = new BuildingPyramid().GetHeight(numberOfBlocks);

            Assert.Equal(5, height);
        }

        [Fact]
        public void Pyramid_With_1000_Blocks()
        {
            int numberOfBlocks = 1000;

            int height = new BuildingPyramid().GetHeight(numberOfBlocks);

            Assert.Equal(44, height);
        }

        [Fact]
        public void Pyramid_With_2_Blocks()
        {
            int numberOfBlocks = 2;

            int height = new BuildingPyramid().GetHeight(numberOfBlocks);

            Assert.Equal(1, height);
        }
    }
}