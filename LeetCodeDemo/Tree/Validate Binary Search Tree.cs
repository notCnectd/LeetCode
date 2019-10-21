// 98. Validate Binary Search Tree;

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Validate_Binary_Search_Tree {
        // 迭代中序遍历
        public static bool IsValidBST1(TreeNode root) {
            double lastOne = Double.MinValue;
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null) {
                stack.Push(root);
                root = root.left;
            }
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                if (lastOne >= node.val) return false;
                else lastOne = node.val;
                if (node.right != null) {
                    stack.Push(node.right);
                    node = node.right;
                    while (node.left != null) {
                        stack.Push(node.left);
                        node = node.left;
                    }
                }
            }
            return true;
        }

        // 递归 最大值最小值
        public bool IsValidBST(TreeNode root) {
            return Helper(root, double.MaxValue, double.MinValue);
        }

        public bool Helper(TreeNode root, double max, double min) {
            if (root == null) return true;
            if (root.val >= max || root.val <= min)
                return false;
            return Helper(root.left, root.val, min) &&
                    Helper(root.right, max, root.val);
        }

        // 迭代
        public bool IsValidBST2(TreeNode root) {
            double max = double.MaxValue, min = double.MinValue;
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<double> maxs = new Stack<double>();
            Stack<double> mins = new Stack<double>();
            stack.Push(root);
            maxs.Push(max);
            mins.Push(min);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                max = maxs.Pop();
                min = mins.Pop();
                if (node.val >= max || node.val <= min)
                    return false;
                if (node.right != null) {
                    stack.Push(node.right);
                    mins.Push(node.val);
                    maxs.Push(max);
                }
                if(node.left != null) {
                    stack.Push(node.left);
                    maxs.Push(node.val);
                    mins.Push(min);
                }
            }
            return true;
        }
    }
}
