using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Trees
{
    public static class PreorderTraversal
    {
        public static void traverse(TreeNode root) {
            if (root == null) { 
                return;
            }
            Console.WriteLine(root.Val.ToString());
            traverse(root.Left);
            traverse(root.Right);
        }
    }
    public static class PostorderTraversal
    {
        public static void traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            traverse(root.Left);
            traverse(root.Right);
            Console.WriteLine(root.Val.ToString());
        }
    }
    public static class InorderTraversal
    {
        public static void traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            traverse(root.Left);
            Console.WriteLine(root.Val.ToString());
            traverse(root.Right);
        }
    }

    public static class LevelorderTraversal
    {
        public static void traverse(TreeNode root)
        {
            Queue<TreeNode> ints = new Queue<TreeNode>();
            ints.Enqueue(root);
            while (ints.Count > 0)
            {
                int len = ints.Count;
                for (int i = 0; i < len; i++) { 
                    TreeNode node = ints.Dequeue();
                    if (node.Left != null) { 
                        ints.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        ints.Enqueue(node.Right);
                    }
                }
            }
        }
    }




}
