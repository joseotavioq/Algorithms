using BenchmarkDotNet.Attributes;
using System.Text;

namespace Algorithms.ArraysAndStrings
{
    /// <summary>
    /// Implement a method to perform basic string compression using the counts of repeated characters.
    /// If the "compressed" string would not become smaller than the original string, your method should
    /// return the original string. You can assume the string has only uppercase and lowercase letters (a-z).
    /// </summary>
    [MemoryDiagnoser]
    public class StringCompression
    {
        //Time: O(n)
        //Space: O(n)
        [Benchmark(Baseline = true)]
        [Arguments("aabcccccaaa")]
        public string FirstTry(string value)
        {
            StringBuilder result = new StringBuilder(value.Length);

            char previousCharacter = ' ';
            int countOfEqualCharacters = 1;
            for (int i = 0; i < value.Length; i++)
            {
                if (previousCharacter == value[i])
                    countOfEqualCharacters++;
                else
                {
                    if (i > 0)
                        result.Append($"{previousCharacter}{countOfEqualCharacters}");

                    countOfEqualCharacters = 1;
                    previousCharacter = value[i];
                }
            }

            if (previousCharacter != ' ')
                result.Append($"{previousCharacter}{countOfEqualCharacters}");

            if (result.Length >= value.Length)
                return value;

            return result.ToString();
        }

        //Time: O(n)
        //Space: O(n)
        [Benchmark]
        [Arguments("aabcccccaaa")]
        public string SecondTry(string value)
        {
            StringBuilder result = new StringBuilder(value.Length);

            char previousCharacter = ' ';
            int countOfEqualCharacters = 1;

            for (int i = 0; i < value.Length; i++)
            {
                if (previousCharacter == value[i])
                    countOfEqualCharacters++;
                else
                {
                    if (i > 0)
                    {
                        result.Append(previousCharacter);
                        result.Append(countOfEqualCharacters);
                    }

                    countOfEqualCharacters = 1;
                    previousCharacter = value[i];
                }
            }

            if (previousCharacter != ' ')
            {
                result.Append(previousCharacter);
                result.Append(countOfEqualCharacters);
            }

            if (result.Length >= value.Length)
                return value;

            return result.ToString();
        }

        //Time: O(n)
        //Space: O(n)
        [Benchmark]
        [Arguments("aabcccccaaa")]
        public string ThirdTry(string value)
        {
            StringBuilder result = new StringBuilder(value.Length);

            int countOfEqualCharacters = 0;

            for (int i = 0; i < value.Length; i++)
            {
                countOfEqualCharacters++;

                if (i + 1 >= value.Length || value[i] != value[i + 1])
                {
                    result.Append(value[i]);
                    result.Append(countOfEqualCharacters);
                    countOfEqualCharacters = 0;
                }
            }

            if (result.Length >= value.Length)
                return value;

            return result.ToString();
        }
    }
}