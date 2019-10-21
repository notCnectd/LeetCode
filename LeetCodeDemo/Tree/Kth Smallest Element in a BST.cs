// 230. Kth Smallest Element in a BST

using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class Kth_Smallest_Element_in_a_BST {
        public int KthSmallest(TreeNode root, int k) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode tmp = root;
            while (tmp != null) {
                stack.Push(tmp);
                tmp = tmp.left;
            }
            if (k == 1) return stack.Peek().val;
            int count = 0;
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                count++;
                if (k == count) return node.val;
                if(node.right != null) {
                    tmp = node.right;
                    while (tmp != null) {
                        stack.Push(tmp);
                        tmp = tmp.left;
                    }
                }
            }
            throw new Exception();  
        }

    }
}
