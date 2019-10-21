// 112. Path Sum

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Path_Sum {
        // 迭代
        public bool HasPathSum1(TreeNode root, int sum) {
            if (root == null) return false;
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            Stack<int> subs = new Stack<int>();
            nodes.Push(root);
            subs.Push(sum - root.val);
            while (nodes.Count > 0) {
                TreeNode node = nodes.Pop();
                sum = subs.Pop();
                if (sum == 0 && node.left == null && node.right == null)
                    return true;
                if (node.right != null) {
                    nodes.Push(node.right);
                    subs.Push(sum - node.right.val);
                }
                if (node.left != null) {
                    nodes.Push(node.left);
                    subs.Push(sum - node.left.val);
                }
            }
            return false;
        }

        // 递归
        public bool HasPathSum(TreeNode root, int sum) {
            if (root == null) return false;
            sum -= root.val;
            if (root.left == null && root.right == null)
                return sum == 0;
            return HasPathSum(root.right, sum) ||
                    HasPathSum(root.left, sum);
        }
    }
}
