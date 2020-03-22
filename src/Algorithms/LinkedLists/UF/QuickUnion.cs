﻿namespace Algorithms.LinkedLists.UF
{
    public class QuickUnion : UnionFind
    {
        public QuickUnion(int numberOfObjects) : base(numberOfObjects) { }

        public override void Union(int x, int y)
        {
            int i = root(x);
            int j = root(y);
            _nodes[i] = j;
        }

        public override bool IsConnected(int x, int y)
        {
            return root(x) == root(y);
        }

        private int root(int i)
        {
            while (i != _nodes[i])
                i = _nodes[i];

            return i;
        }
    }
}