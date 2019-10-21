// 114. Flatten Binary Tree to Linked List

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Flatten_Binary_Tree_to_Linked_List {
        // 前序遍历非递归，需要用到辅助栈
        public static void Flatten1(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if (root == null) return;
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null) {
                    stack.Push(node.left);
                    node.right = stack.Peek();
                    node.left = null;
                }
                if (node.left == null && node.right == null && stack.Count > 0) {
                    node.right = stack.Peek();
                    node.left = null;
                }
                if (stack.Count == 1) node.right = stack.Peek();
            }
        }

        // 后续遍历递归
        public static void Flatten(TreeNode root) {
            if (root == null) return;
            Flatten(root.left);
            Flatten(root.right);
            if (root.left != null) {
                TreeNode node = root.left;
                // 找到左子树的最右节点
                while (node.right != null)
                    node = node.right;
                node.right = root.right;
                root.right = root.left;
                root.left = null;
            }
        }

        // 原地 非递归
        public static void Flatten2(TreeNode root) {
            while (root != null) {
                if (root.left != null) {
                    TreeNode node = root.left;
                    // 找到左子树的最右节点
                    while (node.right != null)
                        node = node.right;
                    node.right = root.right;
                    root.right = root.left;
                    root.left = null;
                }
                root = root.right;
            }
            return;
        }
    }
}
