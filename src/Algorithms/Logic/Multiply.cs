namespace Algorithms.Logic
{
    /// <summary>
    /// Multiply values without using * operator.
    /// </summary>
    public class Multiply
    {
        public int FirstTry(int x, int y)
        {
            bool resultMustBeNegative = ((x < 0 && y >= 0) || (x >= 0 && y < 0));

            x = (x < 0) ? -x : x;
            y = (y < 0) ? -y : y;

            int minValueToUseOnLoop = (x > y) ? y : x;
            int valueToAdd = (x > y) ? x : y;
            int result = 0;

            for (int i = 0; i < minValueToUseOnLoop; i++)
            {
                result += valueToAdd;
            }

            if (resultMustBeNegative)
            {
                result = -result;
            }

            return result;
        }
    }
}