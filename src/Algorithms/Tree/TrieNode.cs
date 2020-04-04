using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class TrieNode
    {
        public char Letter { get; private set; }
        public Dictionary<char, TrieNode> Nodes { get; private set; }
        public bool IsItAFinalLetter { get; private set; }

        public TrieNode(char letter, bool isItAFinalLetter = false)
        {
            Letter = letter;
            IsItAFinalLetter = isItAFinalLetter;
            Nodes = new Dictionary<char, TrieNode>();
        }
    }
}