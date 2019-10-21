// 94. Binary Tree Inorder Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Inorder_Traversal {
        public IList<int> InorderTraversal(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            IList<int> res = new List<int>();
            while (root != null) {
                stack.Push(root);
                root = root.left;
            }
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                res.Add(node.val);
                if (node.right != null) {
                    node = node.right;
                    stack.Push(node);
                    while (node.left != null) {
                        stack.Push(node.left);
                        node = node.left;
                    }
                }
            }
            return res;
        }
    }
}
