using System.Text;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Algorithms
{
    [MemoryDiagnoser]
    public class ArraysAndStrings
    {
        [Benchmark]
        [Arguments("Learning Algorithms!")]
        public string ReverseString(string myEntireString)
        {
            StringBuilder reversedString = new StringBuilder(myEntireString.Length);

            for (int i = myEntireString.Length - 1; i >= 0; i--)
                reversedString.Append(myEntireString[i]);

            return reversedString.ToString();
        }

        [Benchmark]
        [Arguments("Learning Algorithms!")]
        public string ReverseString_OneLine(string myEntireString)
        {
            return string.Join("", myEntireString.ToCharArray().Reverse());
        }
    }
}
