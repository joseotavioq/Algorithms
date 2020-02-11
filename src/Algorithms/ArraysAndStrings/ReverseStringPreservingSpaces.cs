using System.Text;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    [MemoryDiagnoser]
    public class ReverseStringPreservingSpaces
    {
        [Benchmark(Baseline = true)]
        [Arguments("A BB CCC DDDD EEEEE FFFFFF")]
        public string FirstTry(string input)
        {
            var hs = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    hs.Add(i);
            }

            var sb = new StringBuilder(input.Length);

            int start = 0;
            int end = input.Length - 1;
            while (end >= 0)
            {
                if (hs.Contains(start))
                {
                    sb.Append(' ');
                    start++;
                }
                else
                {
                    if (input[end] != ' ')
                    {
                        sb.Append(input[end]);
                        start++;
                    }
                    end--;
                }
            }

            return sb.ToString();
        }

        [Benchmark]
        [Arguments("A BB CCC DDDD EEEEE FFFFFF")]
        public string SecondTry(string input)
        {
            var sb = new StringBuilder(input.Length);

            int start = 0;
            int end = input.Length - 1;
            while (end >= 0)
            {
                if (start < input.Length && input[start] == ' ')
                {
                    sb.Append(' ');
                    start++;
                }
                else
                {
                    if (input[end] != ' ')
                    {
                        sb.Append(input[end]);
                        start++;
                    }
                    end--;
                }
            }

            return sb.ToString();
        }

        [Benchmark]
        [Arguments("A BB CCC DDDD EEEEE FFFFFF")]
        public string ThirdTry(string input)
        {
            var arrayInput = input.ToCharArray();

            for (int i = 0, end = arrayInput.Length - 1; i < arrayInput.Length / 2; i++)
            {
                if (arrayInput[i] != ' ')
                {
                    if (arrayInput[end] == ' ')
                        end--;

                    char tmp = arrayInput[i];
                    arrayInput[i] = arrayInput[end];
                    arrayInput[end] = tmp;

                    end--;
                }
            }

            return new string(arrayInput);
        }
    }
}