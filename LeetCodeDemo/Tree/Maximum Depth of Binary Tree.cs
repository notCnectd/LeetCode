// 104. Maximum Depth of Binary Tree

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Maximum_Depth_of_Binary_Tree {
        // Recursive
        //public int MaxDepth(TreeNode root) {
        //    int left = 0, right = 0;
        //    if (root == null)
        //        return 0;
        //    else {
        //        left = MaxDepth(root.left);
        //        right = MaxDepth(root.right);
        //        return 1 + Math.Max(left, right);
        //    }
        //}
        // Non-recursive
        public static int MaxDepth(TreeNode root) {
            Stack<KeyValuePair<int, TreeNode>> stack = new Stack<KeyValuePair<int, TreeNode>>();
            int depth = 0;
            stack.Push(new KeyValuePair<int, TreeNode>(1, root));
            while (stack.Count != 0) {
                KeyValuePair<int, TreeNode> depthAndNode = stack.Pop();
                int curDepth = depthAndNode.Key;
                depth = Math.Max(depth, curDepth);
                if (depthAndNode.Value.left != null)
                    stack.Push(new KeyValuePair<int, TreeNode>(curDepth + 1, depthAndNode.Value.left));
                if (depthAndNode.Value.right != null)
                    stack.Push(new KeyValuePair<int, TreeNode>(curDepth + 1, depthAndNode.Value.right));
            }
            return depth;
        }
    }
}
