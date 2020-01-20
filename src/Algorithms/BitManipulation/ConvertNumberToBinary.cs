namespace Algorithms.BitManipulation
{
    public class ConvertNumberToBinary
    {
        public int[] FirstTry(sbyte number)
        {
            int[] result = new int[8];
            int index = result.Length - 1;

            while (number > 0)
            {
                int mod = number % 2;
                number /= 2;

                result[index--] = mod;
            }

            return result;
        }
    }
}