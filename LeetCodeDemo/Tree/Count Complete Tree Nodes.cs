//222. Count Complete Tree Nodes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    class Count_Complete_Tree_Nodes {
        // O(n)
        int depth = 0;
        int leaves = 0;
        public int CountNodes1(TreeNode root) {
            Helper(root, 0);
            return (1 << depth) - 1 + leaves;
        }

        private void Helper(TreeNode root, int d) {
            if (root == null) return;
            depth = depth > d ? depth : d;
            if (root.left == null && root.right == null && d == depth) {
                leaves++;
            }
            Helper(root.left, d + 1);
            Helper(root.right, d + 1);
        }

        // O(log2(n))？
        public int CountNodes(TreeNode root) {
            if (root == null) return 0;
            int left = CountLevel(root.left);
            int right = CountLevel(root.right);
            if (left == right)
                return CountNodes(root.right) + (1 << left);
            else
                return CountNodes(root.left) + (1 << right);
        }

        private int CountLevel(TreeNode node) {
            int level = 0;
            while (node != null) {
                level++;
                node = node.left;
            }
            return level;
        }
    }
}
