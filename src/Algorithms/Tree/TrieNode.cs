namespace Algorithms.Tree
{
    public class TrieNode
    {
        public char Letter { get; private set; }
        public TrieNode[] Nodes { get; private set; }
        public bool FinalLetter { get; private set; }

        public TrieNode(char letter, bool finalLetter = false)
        {
            Letter = letter;
            FinalLetter = finalLetter;
            Nodes = new TrieNode[256];
        }
    }
}