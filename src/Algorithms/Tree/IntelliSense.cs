namespace Algorithms.Tree
{
    /// <summary>
    /// Implementation with Tries (Prefix Trees)
    /// </summary>
    public class IntelliSense
    {
        private TrieNode _nodes = new TrieNode('*');

        public int Height { get; private set; } = 0;

        public void AddWord(string word)
        {
            int height = 0;
            var currentNode = _nodes.Nodes;

            foreach (char letter in word)
            {
                if (currentNode[letter] == null)
                    currentNode[letter] = new TrieNode(letter);

                currentNode = currentNode[letter].Nodes;
                height++;
            }

            if (height > Height)
                Height = height;
        }
    }
}