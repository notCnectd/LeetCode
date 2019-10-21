// 129. Sum Root to Leaf Numbers

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Sum_Root_to_Leaf_Numbers {
        // dfs递归
        public static int SumNumbers(TreeNode root) {
            IList<string> paths = new List<string>();
            Helper(root, paths, "");
            int res = 0;
            foreach (string str in paths) {
                res += Convert.ToInt32(str);
            }
            return res;
        }

        public static void Helper(TreeNode root, IList<string> paths, string path) {
            if (root == null) return;
            path += root.val;
            if (root.left == null && root.right == null)
                paths.Add(path);
            Helper(root.left, paths, path);
            Helper(root.right, paths, path);
        }
    }
}
