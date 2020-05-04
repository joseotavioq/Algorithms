namespace Algorithms.LinkedLists.UF
{
    public class WeightedQuickUnionUF : QuickUnionUF
    {
        private int[] _sizes;

        public WeightedQuickUnionUF(int numberOfObjects) : base(numberOfObjects)
        {
            _sizes = new int[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
                _sizes[i] = 1;
        }

        public override void Union(int x, int y)
        {
            int i = root(x);
            int j = root(y);

            if (i != j)
            {
                if (_sizes[i] < _sizes[j])
                {
                    _nodes[i] = j;
                    _sizes[j] += _sizes[i];
                }
                else
                {
                    _nodes[j] = i;
                    _sizes[i] += _sizes[j];
                }
            }
        }

        protected override int root(int i)
        {
            while (i != _nodes[i])
            {
                //keep the tree always completed flat
                _nodes[i] = _nodes[_nodes[i]];
                i = _nodes[i];
            }

            return i;
        }
    }
}