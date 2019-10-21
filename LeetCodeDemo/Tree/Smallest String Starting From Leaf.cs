// 988. Smallest String Starting From Leaf

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Smallest_String_Starting_From_Leaf {
        public static string SmallestFromLeaf(TreeNode root) {
            IList<string> paths = new List<string>();
            Helper(root, paths, "");
            string res = "";
            foreach (string path in paths) {
                if (res.Length == 0) res = path;
                else {
                    int i = res.Length - 1, j = path.Length - 1;
                    while (i >= 0 && j >= 0) {
                        if (path[j] > res[i]) break;
                        else if (path[j] < res[i]) {
                            res = path;
                            break;
                        }
                        i--; j--;
                    }
                    if (res.Length != path.Length && (i == -1 || j == -1)) {
                        res = res.Length < path.Length ? res : path;
                    }
                }
            }
            char[] tmp = res.ToCharArray();
            Array.Reverse(tmp);
            return new string(tmp);

        }

        public static void Helper(TreeNode root, IList<string> paths, string path) {
            if (root == null) return;
            path += (char)(root.val + 'a');
            if (root.left == null && root.right == null) {
                paths.Add(path);
            }
            Helper(root.left, paths, path);
            Helper(root.right, paths, path);
        }
    }
}
