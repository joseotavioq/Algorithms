using Xunit;
using Algorithms.Tree;

namespace AlgorithmsTest.Tree
{
    public class BinaryTreeConverterTest
    {
        [Fact]
        public void Serialize_BinaryTree()
        {
            var tree = new TreeNode<int>(6)
            {
                Left = new TreeNode<int>(5)
                {
                    Left = new TreeNode<int>(4)
                },
                Right = new TreeNode<int>(8)
            };

            var result = new BinaryTreeConverter().Serialize(tree);

            Assert.Equal("6-5-4-null-null-null-8-null-null-", result);
        }

        [Fact]
        public void Deserialize_BinaryTree()
        {
            var inputString = "6-5-4-null-null-null-8-null-null-";

            var result = new BinaryTreeConverter().Deserialize(inputString);

            Assert.Equal(6, result.Value);
            Assert.Equal(5, result.Left.Value);
            Assert.Equal(8, result.Right.Value);
            Assert.Null(result.Right.Left);
            Assert.Null(result.Right.Right);
            Assert.Equal(4, result.Left.Left.Value);
            Assert.Null(result.Left.Right);
        }


        [Fact]
        public void Serialize_More_Elements_BinaryTree()
        {
            var tree = new TreeNode<int>(7)
            {
                Left = new TreeNode<int>(5)
                {
                    Left = new TreeNode<int>(4),
                    Right = new TreeNode<int>(6)
                },
                Right = new TreeNode<int>(8)
            };

            var result = new BinaryTreeConverter().Serialize(tree);

            Assert.Equal("7-5-4-null-null-6-null-null-8-null-null-", result);
        }

        [Fact]
        public void Deserialize_More_Elements_BinaryTree()
        {
            var inputString = "7-5-4-null-null-6-null-null-8-null-null-";

            var result = new BinaryTreeConverter().Deserialize(inputString);

            Assert.Equal(7, result.Value);
            Assert.Equal(5, result.Left.Value);
            Assert.Equal(8, result.Right.Value);
            Assert.Null(result.Right.Left);
            Assert.Null(result.Right.Right);
            Assert.Equal(4, result.Left.Left.Value);
            Assert.Equal(6, result.Left.Right.Value);
        }
    }
}