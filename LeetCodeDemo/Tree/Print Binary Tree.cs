// 655. Print Binary Tree

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Print_Binary_Tree {
        public IList<IList<string>> PrintTree(TreeNode root) {
            int height = GetHeight(root);
            IList<IList<string>> res = new List<IList<string>>();
            if (height == 0) return res;
            int width = GetWidth(1, height - 1);
            Helper(root, res, height, width, 0, 0, width);
            return res;
        }

        private void Helper(TreeNode root, IList<IList<string>> res, int height, int width, int depth, int start, int end) {
            if (root == null) return;
            
            int pos = (end - start) / 2;
            if (res.Count == depth) {
                res.Add(new List<string>(width));
                for (int i = 0; i < width; i++)
                    res[depth].Add("");
                
                res[depth][pos + start] = root.val.ToString();
            } else {
                res[depth][pos + start] = root.val.ToString();
            }

            Helper(root.left, res, height, width, depth + 1, start, pos + start - 1);
            Helper(root.right, res, height, width, depth + 1, pos + start + 1, end);
        }

        private int GetWidth(int width, int times) {
            if (times == 0) return 1;
            times--;
            return GetWidth(width, times) * 2 + 1;
        }

        private int GetHeight(TreeNode root) {
            if (root == null) return 0;
            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
    }
}
