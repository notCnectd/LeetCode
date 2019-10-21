// 515. Find Largest Value in Each Tree Row

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Find_Largest_Value_in_Each_Tree_Row {

        // 递归
        public static IList<int> LargestValues(TreeNode root) {
            IList<int> res = new List<int>();
            Helper(root, res, 0);
            return res;
        }

        public static void Helper(TreeNode root, IList<int> res, int depth) {
            if (root == null) return;
            if (res.Count == depth)
                res.Add(root.val);
            else
                res[depth] = res[depth] > root.val ? res[depth] : root.val;
            Helper(root.left, res, depth + 1);
            Helper(root.right, res, depth + 1);
        }

        // 迭代
        public static IList<int> _LargestValues(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            int depth = 0;
            while (que.Count > 0) {
                int size = que.Count;
                while (size-- > 0) {
                    TreeNode node = que.Dequeue();
                    if (res.Count == depth)
                        res.Add(node.val);
                    else
                        res[depth] = res[depth] > node.val ? res[depth] : node.val;
                    if (node.left != null) que.Enqueue(node.left);
                    if (node.right != null) que.Enqueue(node.right);
                }
                depth++;
            }
            return res;
        }
    }
}
