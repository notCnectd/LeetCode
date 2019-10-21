// 965. Univalued Binary Tree

using System.Collections.Generic;

namespace LeetCodeDemo.Tree
{
    class Univalued_Binary_Tree
    {
        // Non-recursive
        //public bool IsUnivalTree(TreeNode root)
        //{
        //    int val = root.val;
        //    Stack<TreeNode> stack = new Stack<TreeNode>();
        //    stack.Push(root);
        //    while (stack.Count != 0)
        //    {
        //        TreeNode node = stack.Pop();
        //        if (node.val != val) return false;
        //        if (node.left != null) stack.Push(node.left);
        //        if (node.right != null) stack.Push(node.right);
        //    }
        //    return true;
        //}

        // Recursive
        public static bool IsUnivalTree(TreeNode root)
        {
            bool left = root.left == null || root.val == root.left.val && IsUnivalTree(root.left);
            bool right = root.right == null || root.val == root.right.val && IsUnivalTree(root.right);
            return left && right;
        }
    }
}
