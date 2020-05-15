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

            while (positionOfSpaceOrNumber < input.Length - 1)
            {
                bool isNumberOrSpaceOrEndOfString = (input[positionOfSpaceOrNumber] >= '0' && input[positionOfSpaceOrNumber] <= '9')
                                                            || input[positionOfSpaceOrNumber] == ' ';

                if (isNumberOrSpaceOrEndOfString)
                {
                    int end = positionOfSpaceOrNumber - 1;
                    while (start < end)
                        sb.Append(input[end--]);

                    start = positionOfSpaceOrNumber;

                    sb.Append(input[positionOfSpaceOrNumber]);
                }

                positionOfSpaceOrNumber++;
            }

            while (start < positionOfSpaceOrNumber)
                sb.Append(input[positionOfSpaceOrNumber--]);

            return sb.ToString();
        }
    }
}