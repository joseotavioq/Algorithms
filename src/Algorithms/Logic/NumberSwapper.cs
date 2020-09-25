namespace Algorithms.Logic
{
    /// <summary>
    /// Write a function to swap a number in place (that is, without temporary variables)
    /// </summary>
    public class NumberSwapper
    {
        public (int, int) FirstTry(int x, int y)
        {
            if (x != y)
            {
                x = x + y;
                y = x - y;
                x = x - y;
            }

            return (x, y);
        }

        public (int, int) SecondTry(int x, int y)
        {
            if (x != y)
            {
                x = x ^ y;
                y = x ^ y;
                x = x ^ y;
            }

            return (x, y);
        }
    }
}