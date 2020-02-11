namespace Algorithms.ArraysAndStrings
{
    public class Rotate90Degrees
    {
        public string[,] FirstTry(string[,] contents, int n)
        {
            string[,] newContent = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int posi = n - j - 1;
                    newContent[i, j] = contents[posi, i];
                }
            }

            return newContent;
        }
    }
}