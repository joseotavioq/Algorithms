namespace Algorithms.LinkedLists.UF
{
    public class QuickFindUF
    {
        protected int[] _nodes;

        public int[] Nodes
        {
            get { return _nodes; }
        }

        public QuickFindUF(int numberOfObjects)
        {
            _nodes = new int[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
                _nodes[i] = i;
        }

        public virtual void Union(int x, int y)
        {
            int xNode = _nodes[x];
            int yNode = _nodes[y];

            for (int i = 0; i < _nodes.Length; i++)
                if (_nodes[i] == xNode)
                    _nodes[i] = yNode;
        }

        public virtual bool IsConnected(int x, int y)
        {
            return _nodes[x] == _nodes[y];
        }

        public int Find(int x)
        {
            return _nodes[x];
        }

        public int Count()
        {
            return _nodes.Length;
        }
    }
}