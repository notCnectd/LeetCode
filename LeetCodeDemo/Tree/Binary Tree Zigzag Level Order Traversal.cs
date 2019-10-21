// 103. Binary Tree Zigzag Level Order Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Zigzag_Level_Order_Traversal {
        // 迭代
        public static IList<IList<int>> ZigzagLevelOrder1(TreeNode root) {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            int flag = 0;
            stack.Push(root);
            while (stack.Count > 0) {
                IList<int> list = new List<int>();
                IList<TreeNode> nodes = new List<TreeNode>();
                TreeNode node;
                while (stack.Count > 0) {
                    node = stack.Pop();
                    list.Add(node.val);
                    nodes.Add(node);
                }
                if (flag == 0) {
                    foreach (TreeNode n in nodes) {
                        if (n.left != null) stack.Push(n.left);
                        if (n.right != null) stack.Push(n.right);
                    }
                } else {
                    foreach (TreeNode n in nodes) {
                        if (n.right != null) stack.Push(n.right);
                        if (n.left != null) stack.Push(n.left);
                    }
                }
                flag = flag == 0 ? 1 : 0;
                res.Add(list);
            }
            return res;
        }

        // 递归
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            IList<IList<int>> res = new List<IList<int>>();
            Helper(root, res, 0);
            return res;
        }

        public static void Helper(TreeNode node, IList<IList<int>> res, int depth) {
            if (node == null) return;
            if(res.Count == depth)
                res.Add(new List<int>());
            if (depth % 2 == 0) res[depth].Add(node.val);
            else res[depth].Insert(0, node.val);
            Helper(node.left, res, depth + 1);
            Helper(node.right, res, depth + 1);
        }
    }
}
