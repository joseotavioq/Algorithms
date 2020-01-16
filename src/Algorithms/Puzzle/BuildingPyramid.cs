namespace Algorithms.Puzzle
{
    public class BuildingPyramid
    {
        public int GetHeight(int numberOfBlocks)
        {
            int height = 0;

            for (int i = 1, blocksProcessed = 0; blocksProcessed < numberOfBlocks; i++)
            {
                blocksProcessed += i;

                if (blocksProcessed <= numberOfBlocks)
                    height++;
            }

            return height;
        }
    }
}