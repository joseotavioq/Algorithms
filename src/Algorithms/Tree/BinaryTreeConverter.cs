using System.Text;

namespace Algorithms.Tree
{
    public class BinaryTreeConverter
    {
        public string Serialize(TreeNode<int> tree)
        {
            var sb = new StringBuilder();

            RecursiveBuildString(tree, sb);

            return sb.ToString();
        }

        private void RecursiveBuildString(TreeNode<int> tree, StringBuilder sb)
        {
            if (tree == null)
            {
                sb.Append("null-");
            }
            else
            {
                sb.Append(tree.Value);
                sb.Append("-");

                RecursiveBuildString(tree.Left, sb);

                RecursiveBuildString(tree.Right, sb);
            }
        }

        public TreeNode<int> Deserialize(string mystring)
        {
            if (string.IsNullOrEmpty(mystring) || mystring == "null-")
                return null;

            TreeNode<int> head = null;

            var child = mystring.Split('-');

            if (child.Length > 0)
            {
                int position = 0;
                head = AddElement(child, ref position);
            }

            return head;
        }

        private TreeNode<int> AddElement(string[] child, ref int position)
        {
            if (position >= child.Length || child[position] == "null")
                return null;

            var item = new TreeNode<int>(int.Parse(child[position]));

            position++;
            item.Left = AddElement(child, ref position);

            position++;
            item.Right = AddElement(child, ref position);

            return item;
        }
    }
}