namespace Algoritmos
{
    public class SearchMatrix
    {
        //Time: O(n)
        public static int CountNegativeIntegers(int[,] matrixOfNumbers)
        {
            int i = 0, j = matrixOfNumbers.GetLength(0) - 1, count = 0;

            while (j >= 0 && i < matrixOfNumbers.Rank)
            {
                if (matrixOfNumbers[i, j] < 0)
                {
                    count += j + 1;
                    i++;
                }
                else
                {
                    j -= 1;
                }
            }

            return count;
        }
    }
}