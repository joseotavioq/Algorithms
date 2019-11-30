using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class BinarySearchTree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public void Insert(T value)
        {
            var node = new TreeNode<T>(value);

            if (Root == null)
                Root = node;
            else
            {
                var current = Root;
                while (current != null)
                {
                    var result = Comparer<T>.Default.Compare(value, current.Value);

                    if (result > 0)
                    {
                        if (current.Right == null)
                        {
                            current.Right = node;
                            break;
                        }

                        current = current.Right;
                    }
                    else
                    {
                        if (current.Left == null)
                        {
                            current.Left = node;
                            break;
                        }

                        current = current.Left;
                    }
                }
            }
        }

        public TreeNode<T> Find(T value)
        {
            var current = Root;
            while (current != null)
            {
                var result = Comparer<T>.Default.Compare(value, current.Value);

                if (result > 0)
                    current = current.Right;
                else if (result < 0)
                    current = current.Left;
                else
                    return current;
            }

            return null;
        }
    }
}