namespace Algorithms.ArraysAndStrings
{
    public class Rotate90Degrees
    {
        public string[,] FirstTry(string[,] contents)
        {
            if (contents == null || contents.Length <= 1)
                return null;

            int n = contents.GetLength(0);

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