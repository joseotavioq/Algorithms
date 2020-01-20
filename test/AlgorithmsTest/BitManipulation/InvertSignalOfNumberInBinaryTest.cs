using Algorithms.BitManipulation;
using Xunit;

namespace AlgorithmsTest.BitManipulation
{
    public class InvertSignalOfNumberInBinaryTest
    {
        [Fact]
        public void Convert_Signal_Of_18_To_Negative_In_Binary()
        {
            sbyte number = 18;

            byte[] result = new InvertSignalOfNumberInBinary().FirstTry(number);

            //-18
            Assert.Equal(new byte[] { 1, 1, 1, 0, 1, 1, 1, 0 }, result);
        }

        [Fact]
        public void Convert_Signal_Of_123_To_Negative_In_Binary()
        {
            sbyte number = 123;

            byte[] result = new InvertSignalOfNumberInBinary().FirstTry(number);

            //-123
            Assert.Equal(new byte[] { 1, 0, 0, 0, 0, 1, 0, 1 }, result);
        }
    }
}