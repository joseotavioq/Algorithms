namespace Algorithms.Tree
{
    public class TrieNode
    {
        public char Letter { get; private set; }
        public TrieNode[] Nodes { get; private set; }

        public TrieNode(char letter)
        {
            Letter = letter;
            Nodes = new TrieNode[256];
        }
    }
}