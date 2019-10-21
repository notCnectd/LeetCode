// 404. Sum of Left Leaves

using System.Collections.Generic;

namespace LeetCodeDemo.Tree
{
    class Sum_of_Left_Leaves
    {
        // Recursion
        //static int sum = 0;
        //public int SumOfLeftLeaves(TreeNode root)
        //{
        //    if (root == null) return sum;
        //    if (root.left != null && root.left.left == null && root.left.right == null)
        //        sum += root.left.val;
        //    SumOfLeftLeaves(root.left);
        //    SumOfLeftLeaves(root.right);
        //    return sum;
        //}

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;   
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if (node.left != null && node.left.left == null && node.left.right == null)
                    sum += node.left.val;
                if (node.left != null)
                    stack.Push(node.left);
                if (node.right != null)
                    stack.Push(node.right);
            }
            return sum;
        }
    }
}
