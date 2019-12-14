using System;

namespace Algorithms.Tree
{
    public class TreeNode<T> : ICloneable
    {
        public T Value { get; private set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public object Clone()
        {
            var current = new TreeNode<T>(this.Value);

            if (Left != null)
                current.Left = this.Left.Clone() as TreeNode<T>;

            if (Right != null)
                current.Right = this.Right.Clone() as TreeNode<T>;

            return current;
        }
    }
}