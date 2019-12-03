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

        public void Remove(T value)
        {
            TreeNode<T> previous = null;

            var current = Root;
            while (current != null)
            {
                var result = Comparer<T>.Default.Compare(value, current.Value);

                if (result > 0)
                {
                    previous = current;
                    current = current.Right;
                }
                else if (result < 0)
                {
                    previous = current;
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        if (previous == null)
                            Root = current.Left;
                        else if (Comparer<T>.Default.Compare(current.Value, previous.Value) < 0)
                            previous.Left = current.Left;
                        else if (Comparer<T>.Default.Compare(current.Value, previous.Value) > 0)
                            previous.Right = current.Left;
                    }
                    else if (current.Right.Left == null)
                    {
                        if (previous == null)
                            Root = current.Left;
                        else
                        {
                            current.Right.Left = current.Left;
                            if (Comparer<T>.Default.Compare(current.Value, previous.Value) < 0)
                                previous.Left = current.Right;
                            else if (Comparer<T>.Default.Compare(current.Value, previous.Value) > 0)
                                previous.Right = current.Right;
                        }
                    }
                    else
                    {
                        var leftMost = current.Right.Left;
                        var leftMostParent = current.Right;
                        while (leftMost.Left != null)
                        {
                            leftMostParent = leftMost;
                            leftMost = leftMost.Left;
                        }

                        leftMostParent.Left = leftMost.Right;
                        leftMost.Left = current.Left;
                        leftMost.Right = current.Right;

                        if (previous == null)
                            Root = leftMost;
                        else if (Comparer<T>.Default.Compare(current.Value, previous.Value) < 0)
                            previous.Left = leftMost;
                        else if (Comparer<T>.Default.Compare(current.Value, previous.Value) > 0)
                            previous.Right = leftMost;
                    }

                    break;
                }
            }
        }

        public void PrintInOrderTraversal() => InOrderTraversal(Root);

        private void InOrderTraversal(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                System.Console.WriteLine(node.Value);
                InOrderTraversal(node.Right);
            }
        }

        public void PrintPreOrderTraversal() => PreOrderTraversal(Root);

        private void PreOrderTraversal(TreeNode<T> node)
        {
            if (node != null)
            {
                System.Console.WriteLine(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PrintPostOrderTraversal() => PostOrderTraversal(Root);

        private void PostOrderTraversal(TreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                System.Console.WriteLine(node.Value);
            }
        }
    }
}