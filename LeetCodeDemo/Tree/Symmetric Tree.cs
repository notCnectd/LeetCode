// 101. Symmetric Tree

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Symmetric_Tree {
        // 迭代
        public static bool IsSymmetric1(TreeNode root) {
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            TreeNode leftNode = root;
            TreeNode rightNode = root;
            while (leftNode != null) {
                s1.Push(leftNode);
                leftNode = leftNode.left;
            }
            while (rightNode != null) {
                s2.Push(rightNode);
                rightNode = rightNode.right;
            }
            if (s1.Count != s2.Count) return false;
            while (s1.Count > 0 && s2.Count > 0) {
                leftNode = s1.Pop();
                rightNode = s2.Pop();
                if (leftNode.val != rightNode.val) return false;
                //
                if (leftNode.right != null) {
                    leftNode = leftNode.right;
                    s1.Push(leftNode);
                    while (leftNode.left != null) {
                        s1.Push(leftNode.left);
                        leftNode = leftNode.left;
                    }
                }
                //
                if (rightNode.left != null) {
                    rightNode = rightNode.left;
                    s2.Push(rightNode);
                    while (rightNode.right != null) {
                        s2.Push(rightNode.right);
                        rightNode = rightNode.right;
                    }
                }
            }
            if (s1.Count != s2.Count) return false;
            return true;

        }

        // 递归
        public bool IsSymmetric(TreeNode root) {
            return Helper(root, root);
        }

        public bool Helper(TreeNode leftNode, TreeNode rightNode) {
            if (leftNode == null && rightNode == null) return true;
            if (leftNode == null || rightNode == null) return false;
            return leftNode.val == rightNode.val &&
                Helper(leftNode.left, rightNode.right) &&
                Helper(leftNode.right, rightNode.left);
        }
    }
}
