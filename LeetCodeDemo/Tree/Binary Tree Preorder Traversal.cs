// 144. Binary Tree Preorder Traversal
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Preorder_Traversal {
        public IList<int> PreorderTraversal(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                res.Add(node.val);
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);
            }
            return res;
        }
    }
}
