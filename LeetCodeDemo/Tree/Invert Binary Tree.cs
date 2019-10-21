// 226. Invert Binary Tree

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Invert_Binary_Tree {
        // 迭代
        public TreeNode InvertTree2(TreeNode root) {
            if (root == null) return root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode node = new TreeNode(0);
            while (stack.Count > 0) {
                node = stack.Pop();
                TreeNode tmp = node.left;
                node.left = node.right;
                node.right = tmp;
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);        
            }
            return root;
        }

        // 递归
        public static TreeNode InvertTree(TreeNode root) {
            if (root == null) return null;
            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            if (root.left != null) InvertTree(root.left);                   
            if (root.right != null) InvertTree(root.right);
            return root;
        }
    }
}
