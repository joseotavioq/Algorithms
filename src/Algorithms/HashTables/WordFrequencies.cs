using System.Collections.Generic;

namespace Algorithms.HashTables
{
    /// <summary>
    /// Design a method to find the frequency of occurrences of any given word in a book.
    /// What if we were running this algorithm multiple times?
    /// </summary>
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

        public int FirstTry(string sentence, string word)
        {
            if (string.IsNullOrEmpty(sentence))
                return 0;

            int count = 0;

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (string.Compare(words[i], word, true) == 0)
                    count++;
            }

            return count;
        }

        public int SecondTry(string word)
        {
            if (_wordsCount == null)
                return 0;

            if (_wordsCount.ContainsKey(word))
                return _wordsCount[word];

            return 0;
        }
    }
}