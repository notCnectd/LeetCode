// 199. Binary Tree Right Side View

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Right_Side_View {
        public IList<int> RightSideView(TreeNode root) {
            IList<int> res = new List<int>();
            Helper(root, res, 0);
            return res;
        }

        private void Helper(TreeNode root, IList<int> res, int depth) {
            if (root == null) return;
            if (res.Count == depth)
                res.Add(root.val);
            // 先右后左
            Helper(root.right, res, depth + 1);
            Helper(root.left, res, depth + 1);
        }
    }
}
