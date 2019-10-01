using BenchmarkDotNet.Attributes;

namespace Algorithms.ArraysAndStrings
{
    /// <summary>
    /// Write a method to replace all spaces in a string with '%20'.
    /// You may assume that the string has sufficient space at the end to hold
    /// the additional characters, and that you are given the "true" length of
    /// the string.
    /// </summary>
    [MemoryDiagnoser]
    public class URLify
    {
        //Time: O(n)
        //Space: O(n)
        [Benchmark(Baseline = true)]
        [Arguments("Mr John Smith    ")]
        public string FirstTry(string value)
        {
            char[] urlIfied = new char[value.Length];
            int j = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                    urlIfied[j++] = value[i];
                else
                {
                    urlIfied[j++] = '%';
                    urlIfied[j++] = '2';
                    urlIfied[j++] = '0';
                }

                if (j == value.Length)
                    break;
            }

            return new string(urlIfied);
        }
    }
}