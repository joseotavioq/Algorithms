namespace Algorithms.BitManipulation
{
    public class InvertSignalOfNumberInBinary
    {
        public byte[] FirstTry(sbyte number)
        {
            var convertToBinary = new ConvertNumberToBinary().FirstTry(number);

            for (int i = 0; i < convertToBinary.Length; i++)
            {
                convertToBinary[i] = (byte)((convertToBinary[i] == 1) ? 0 : 1);
            }

            for (int i = convertToBinary.Length - 1; i >= 0; i--)
            {
                if (convertToBinary[i] == 0)
                {
                    convertToBinary[i] = 1;
                    break;
                }
                else
                {
                    convertToBinary[i] = 0;
                }
            }

            return convertToBinary;
        }
    }
}