// 113. Path Sum II

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Path_Sum_II {

        public IList<IList<int>> PathSum(TreeNode root, int sum) {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null) return res;
            Helper(root, sum, res, new List<int>());
            return res;
        }

        public void Helper(TreeNode root, int sum, IList<IList<int>> res, IList<int> path) {
            if (root == null) return;
            path.Add(root.val);
            if (root.left == null && root.right == null)
                if (sum - root.val == 0) res.Add(new List<int>(path));
            Helper(root.left, sum - root.val, res, path);
            Helper(root.right, sum - root.val, res, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
