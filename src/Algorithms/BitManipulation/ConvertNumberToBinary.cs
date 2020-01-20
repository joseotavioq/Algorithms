namespace Algorithms.BitManipulation
{
    public class ConvertNumberToBinary
    {
        public byte[] FirstTry(sbyte number)
        {
            byte[] result = new byte[8];
            int index = result.Length - 1;

            while (number > 0)
            {
                int mod = number % 2;
                number /= 2;

                result[index--] = (byte)mod;
            }

            return result;
        }
    }
}