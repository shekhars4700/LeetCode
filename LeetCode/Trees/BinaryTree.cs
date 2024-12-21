using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Trees
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }
    }
    public class BinaryTree
    {
        public static TreeNode CreateTreeFromList(List<int?> values)
        {
            if (values == null || values.Count == 0 || values[0] == null)
                return null;

            TreeNode root = new TreeNode(values[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < values.Count)
            {
                TreeNode current = queue.Dequeue();

                // Add left child
                if (i < values.Count && values[i] != null)
                {
                    current.Left = new TreeNode(values[i].Value);
                    queue.Enqueue(current.Left);
                }
                i++;

                // Add right child
                if (i < values.Count && values[i] != null)
                {
                    current.Right = new TreeNode(values[i].Value);
                    queue.Enqueue(current.Right);
                }
                i++;
            }

            return root;
        }
    }
}
