using Algorithms.Tree;
using Xunit;

namespace AlgorithmsTest.Tree
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void Insert_7_Elements()
        {
            var bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            Assert.Equal(9, bst.Root.Value);

            Assert.Equal(4, bst.Root.Left.Value);
            Assert.Equal(1, bst.Root.Left.Left.Value);
            Assert.Equal(6, bst.Root.Left.Right.Value);

            Assert.Equal(20, bst.Root.Right.Value);
            Assert.Equal(170, bst.Root.Right.Right.Value);
            Assert.Equal(15, bst.Root.Right.Left.Value);
        }

        [Fact]
        public void Find_Element_20()
        {
            var bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            //        9
            //       / \
            //      4   20
            //     / \  / \
            //    1  6 15  170
            var treeNode = bst.Find(20);

            Assert.Equal(20, treeNode.Value);
            Assert.Equal(15, treeNode.Left.Value);
            Assert.Equal(170, treeNode.Right.Value);
        }

        [Fact]
        public void Find_Element_9()
        {
            var bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            //        9
            //       / \
            //      4   20
            //     / \  / \
            //    1  6 15  170
            var treeNode = bst.Find(9);

            Assert.Equal(9, treeNode.Value);
            Assert.Equal(4, treeNode.Left.Value);
            Assert.Equal(20, treeNode.Right.Value);
            Assert.Equal(1, treeNode.Left.Left.Value);
            Assert.Equal(170, treeNode.Right.Right.Value);
            Assert.Equal(6, treeNode.Left.Right.Value);
            Assert.Equal(15, treeNode.Right.Left.Value);
        }

        [Fact]
        public void Do_Not_Find_Element_30()
        {
            var bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            var treeNode = bst.Find(30);

            Assert.Null(treeNode);
        }

        [Fact]
        public void Remove_Element_20()
        {
            var bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);

            bst.Remove(20);

            Assert.Equal(9, bst.Root.Value);

            Assert.Equal(4, bst.Root.Left.Value);
            Assert.Equal(1, bst.Root.Left.Left.Value);
            Assert.Equal(6, bst.Root.Left.Right.Value);

            Assert.Equal(170, bst.Root.Right.Value);
            Assert.Equal(15, bst.Root.Right.Left.Value);
            Assert.Null(bst.Root.Right.Right);
        }
    }
}