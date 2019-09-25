using System.Text;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Algorithms
{
    [MemoryDiagnoser]
    public class ArraysAndStrings
    {
        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString(string myEntireString)
        {
            StringBuilder reversedString = new StringBuilder(myEntireString.Length);

            for (int i = myEntireString.Length - 1; i >= 0; i--)
                reversedString.Append(myEntireString[i]);

            return reversedString.ToString();
        }

        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString_OneLine(string myEntireString)
        {
            return string.Join("", myEntireString.ToCharArray().Reverse());
        }

        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString_OneLine1(string myEntireString) {
            return new string(myEntireString.Reverse().ToArray());
        }

        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString_Fast(string myEntireString)
        {
            int halfSize = myEntireString.Length / 2;

            char[] reversedArray = new char[myEntireString.Length];

            for (int i = 0; i < halfSize; i++)
            {
                reversedArray[i] = myEntireString[myEntireString.Length - 1 - i];
                reversedArray[reversedArray.Length - 1 - i] = myEntireString[i];
            }

            if (halfSize % 2 != 0)
                reversedArray[halfSize] = myEntireString[halfSize];

            return new string(reversedArray);
        }

        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString_FastVafzamora1(string myEntireString) {

            char[] reversedArray = myEntireString.ToCharArray();
            char buffer=' ';

            for (int i = 0,  j = myEntireString.Length-1; i < myEntireString.Length / 2; i++, j--) {
                buffer = reversedArray[i];
                reversedArray[i] = reversedArray[j];
                reversedArray[j] = buffer;
            }

            return new string(reversedArray);
        }

        [Benchmark]
        [Arguments("Learning Algorithms")]
        public string ReverseString_FastVafzamora2(string myEntireString) {

            char[] reversedArray = new char[myEntireString.Length];

            for (int i = 0, j = myEntireString.Length - 1; i < (myEntireString.Length/2 + myEntireString.Length % 2); i++, j--) {
                reversedArray[i] = myEntireString[j];
                reversedArray[j] = myEntireString[i];
            }

            return new string(reversedArray);
        }
    }
}
