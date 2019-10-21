// 145. Binary Tree Postorder Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Postorder_Traversal {
        public IList<int> PostorderTraversal(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<TreeNode> outPut = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || stack.Count > 0) {
                if (node != null) {
                    stack.Push(node);
                    outPut.Push(node);
                    node = node.right;
                } else {
                    node = stack.Pop();
                    node = node.left;
                }
            }
            IList<int> res = new List<int>();
            while (outPut.Count > 0)
                res.Add(outPut.Pop().val);
            return res;
        }
    }
}
