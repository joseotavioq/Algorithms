using System.Text;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Stacks
{
    [MemoryDiagnoser]
    public class ReverseEachWord
    {
        [Benchmark(Baseline = true)]
        [Arguments("The quick brown foxes jump over the lazy fuzzy hounds")]
        public string FirstTry(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            List<Stack<char>> wordsInverted = new List<Stack<char>>();

            if (input[0] != ' ')
                wordsInverted.Add(new Stack<char>());

            foreach (char letter in input)
            {
                if (letter == ' ')
                    wordsInverted.Add(new Stack<char>());
                else
                    wordsInverted[wordsInverted.Count - 1].Push(letter);
            }

            var sb = new StringBuilder(input.Length);

            for (int i = 0; i < wordsInverted.Count; i++)
            {
                while (wordsInverted[i].Count > 0)
                {
                    sb.Append(wordsInverted[i].Pop());
                }

                if (i < wordsInverted.Count - 1)
                    sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}