using Algorithms.Tree;
using Xunit;

namespace AlgorithmsTest.Tree
{
    public class IsItSymetricTest
    {
        [Fact]
        public void Symetric_Tree()
        {
            var tree = new TreeNode<int>(1);

            tree.Left = new TreeNode<int>(2);
            tree.Left.Left = new TreeNode<int>(3);
            tree.Left.Right = new TreeNode<int>(4);
            tree.Left.Left.Left = new TreeNode<int>(5);
            tree.Left.Left.Right = new TreeNode<int>(6);

            tree.Right = new TreeNode<int>(2);
            tree.Right.Right = new TreeNode<int>(3);
            tree.Right.Left = new TreeNode<int>(4);
            tree.Right.Right.Right = new TreeNode<int>(5);
            tree.Right.Right.Left = new TreeNode<int>(6);

            var result = new IsItSymetric().FirstTry(tree);

            Assert.True(result);
        }

        [Fact]
        public void Assymetric_Tree()
        {
            var tree = new TreeNode<int>(1);

            tree.Left = new TreeNode<int>(2);
            tree.Left.Left = new TreeNode<int>(3);
            tree.Left.Right = new TreeNode<int>(4);
            tree.Left.Left.Left = new TreeNode<int>(5);
            tree.Left.Left.Right = new TreeNode<int>(6);

            tree.Right = new TreeNode<int>(2);
            tree.Right.Right = new TreeNode<int>(3);
            tree.Right.Left = new TreeNode<int>(4);
            tree.Right.Right.Right = new TreeNode<int>(6);
            tree.Right.Right.Left = new TreeNode<int>(5);

            var result = new IsItSymetric().FirstTry(tree);

            Assert.False(result);
        }
    }
}