using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Algorithms.HashTables
{
    /// <summary>
    /// Design a method to find the frequency of occurrences of any given word in a book.
    /// What if we were running this algorithm multiple times?
    /// </summary>
    [MemoryDiagnoser]
    public class WordFrequencies
    {
        private Dictionary<string, int> _wordsCount = null;

        public WordFrequencies(string sentence)
        {
            _wordsCount = new Dictionary<string, int>();

            if (!string.IsNullOrEmpty(sentence))
            {
                string[] words = sentence.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    string toLower = words[i].ToLower();

                    if (_wordsCount.ContainsKey(toLower))
                    {
                        _wordsCount[toLower]++;
                    }
                    else
                    {
                        _wordsCount.Add(toLower, 1);
                    }
                }
            }
        }

        public WordFrequencies()
        {
        }

        [Benchmark(Baseline = true)]
        [Arguments("This is my sentence and I can write anything one this sentence because this is mine!", "this")]
        public int FirstTry(string sentence, string word)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return 0;
            }

            int count = 0;

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (string.Compare(words[i], word, true) == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int SecondTry(string word)
        {
            if (_wordsCount == null)
            {
                return 0;
            }

            if (_wordsCount.ContainsKey(word))
            {
                return _wordsCount[word];
            }

            return 0;
        }

        [Benchmark]
        [Arguments("This is my sentence and I can write anything one this sentence because this is mine!", "this")]
        public int ThirdTry(string sentence, string word)
        {
            int count = 0;
            int indexWord = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (indexWord < word.Length && toLowerCase(sentence[i]) == toLowerCase(word[indexWord]))
                {
                    indexWord++;
                }
                else
                {
                    if (indexWord == word.Length)
                    {
                        count++;
                    }

                    indexWord = 0;
                }
            }

            return count;
        }

        private char toLowerCase(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                c = (char)(c - ('A' - 'a'));
            }

            return c;
        }
    }
}