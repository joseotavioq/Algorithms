using System.Collections.Generic;

namespace Algorithms.Tree
{
    /// <summary>
    /// Implementation with Tries (Prefix Trees)
    /// </summary>
    public class IntelliSense
    {
        private TrieNode _nodes = new TrieNode('*');

        public int Depth { get; private set; } = 0;

        public void AddWord(string word)
        {
            var currentNode = _nodes.Nodes;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (currentNode[letter] == null)
                    currentNode[letter] = new TrieNode(letter, (i == word.Length - 1));

                currentNode = currentNode[letter].Nodes;
            }

            if (word.Length > Depth)
                Depth = word.Length;
        }

        public List<string> Find(string prefix)
        {
            List<string> words = new List<string>();

            bool prefixFound = true;
            var node = _nodes;
            var currentNode = node.Nodes;
            foreach (char letter in prefix)
            {
                node = currentNode[letter];

                if (node == null)
                {
                    prefixFound = false;
                    break;
                }

                currentNode = node.Nodes;
            }

            if (prefixFound)
            {
                GetWord(node, prefix, words);

                if (node.FinalLetter)
                    words.Add(prefix);
            }

            return words;
        }

        private void GetWord(TrieNode node, string prefix, List<string> words)
        {
            if (node != null)
            {
                foreach (var item in node.Nodes)
                {
                    if (item != null)
                    {
                        var p = prefix + item.Letter;
                        GetWord(item, p, words);

                        if (item.FinalLetter)
                            words.Add(p);
                    }
                }
            }
        }
    }
}