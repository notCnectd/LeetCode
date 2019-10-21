// 662. Maximum Width of Binary Tree

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Maximum_Width_of_Binary_Tree {
        public static int WidthOfBinaryTree(TreeNode root) {
            int res = 1;
            if (root == null) return 0;
            Queue<TreeNode> que = new Queue<TreeNode>();
            List<int> list = new List<int>();
            que.Enqueue(root);
            list.Add(1);
            int size = 1;
            while (que.Count > 0) {
                TreeNode node = que.Dequeue();
                size--;
                int rootIndex = list[0];
                list.RemoveAt(0);
                if (node.left != null) {
                    que.Enqueue(node.left);
                    list.Add(rootIndex * 2);
                }
                if(node.right != null) {
                    que.Enqueue(node.right);
                    list.Add(rootIndex * 2 + 1);
                }
                if(size == 0) {
                    if(list.Count >= 2) {
                        res = Math.Max(res, list[list.Count - 1] - list[0] + 1);
                    }
                }
            }
            return res;
        }

    }
}
