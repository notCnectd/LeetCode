// 102. Binary Tree Level Order Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Level_Order_Traversal {
        public static IList<IList<int>> LevelOrder(TreeNode root) {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null) return res;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                IList<int> list = new List<int>();
                IList<TreeNode> nodes = new List<TreeNode>();
                while (queue.Count != 0) {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.val);
                    nodes.Add(node);
                }
                foreach (TreeNode treeNode in nodes) {
                    if (treeNode.left != null)
                        queue.Enqueue(treeNode.left);
                    if (treeNode.right != null)
                        queue.Enqueue(treeNode.right);
                }           
                res.Add(list);
            }
            return res;
        }

    }
}
