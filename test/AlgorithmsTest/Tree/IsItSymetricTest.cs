using Algorithms.Tree;
using Xunit;

namespace AlgorithmsTest.Tree
{
    public class IsItSymetricTest
    {
        [Fact]
        public void Symetric_Tree()
        {
            var tree = new TreeNode<int>(1)
            {
                Left = new TreeNode<int>(2)
                {
                    Left = new TreeNode<int>(3)
                    {
                        Left = new TreeNode<int>(5),
                        Right = new TreeNode<int>(6)
                    },
                    Right = new TreeNode<int>(4)
                },
                Right = new TreeNode<int>(2)
                {
                    Left = new TreeNode<int>(4),
                    Right = new TreeNode<int>(3)
                    {
                        Left = new TreeNode<int>(6),
                        Right = new TreeNode<int>(5)
                    }
                }
            };

            var result = new IsItSymetric().FirstTry(tree);

            Assert.True(result);
        }

        [Fact]
        public void Assymetric_Tree()
        {
            var tree = new TreeNode<int>(1)
            {
                Left = new TreeNode<int>(2)
                {
                    Left = new TreeNode<int>(3)
                    {
                        Left = new TreeNode<int>(5),
                        Right = new TreeNode<int>(6)
                    },
                    Right = new TreeNode<int>(4)
                },
                Right = new TreeNode<int>(2)
                {
                    Left = new TreeNode<int>(4),
                    Right = new TreeNode<int>(3)
                    {
                        Left = new TreeNode<int>(5),
                        Right = new TreeNode<int>(6)
                    }
                }
            };

            var result = new IsItSymetric().FirstTry(tree);

            Assert.False(result);
        }
    }
}