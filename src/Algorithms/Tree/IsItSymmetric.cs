namespace Algorithms.Tree
{
    public class IsItSymmetric
    {
        public bool FirstTry(TreeNode<int> root)
        {
            if (root == null)
            {
                return true;
            }

            return isMirror(root.Left, root.Right);
        }

        private bool isMirror(TreeNode<int> left, TreeNode<int> right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left == null || right == null)
            {
                return false;
            }
            else if (left.Value != right.Value)
            {
                return false;
            }

            return isMirror(left.Left, right.Right)
               && isMirror(left.Right, right.Left);
        }
    }
}