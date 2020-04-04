using System.Text;
using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class ReverseWordsPreservingNumbers
    {
        [Benchmark(Baseline = true)]
        [Arguments("The quick, bro567wn 125 foxes jump over the lazy, fuzzy, hounds!")]
        public string FirstTry(string input)
        {
            var sb = new StringBuilder(input.Length);

            int start = -1;
            int positionOfSpaceOrNumber = 0;

            while (start < input.Length && positionOfSpaceOrNumber < input.Length)
            {
                bool isLowerLetter = input[positionOfSpaceOrNumber] >= 'a' && input[positionOfSpaceOrNumber] <= 'z';
                bool isUpperLetter = input[positionOfSpaceOrNumber] >= 'A' && input[positionOfSpaceOrNumber] <= 'Z';

                if (!(isLowerLetter || isUpperLetter))
                {
                    int end = positionOfSpaceOrNumber - 1;
                    while (start < end)
                    {
                        sb.Append(input[end]);
                        end--;
                    }

                    start = positionOfSpaceOrNumber;

                    sb.Append(input[positionOfSpaceOrNumber]);
                }

                positionOfSpaceOrNumber++;
            }

            return sb.ToString();
        }
    }
}