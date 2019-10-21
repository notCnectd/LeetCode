// 173. Binary Search Tree Iterator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class BSTIterator {
        Stack<TreeNode> stack;
        public BSTIterator(TreeNode root) {
            stack = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null) {
                stack.Push(node);
                node = node.left;
            }
        }

        /** @return the next smallest number */
        public int Next() {
            TreeNode smallest = stack.Pop();
            int ans = smallest.val;
            if (smallest.right != null) {
                smallest = smallest.right;
                while (smallest != null) {
                    stack.Push(smallest);
                    smallest = smallest.left;
                }
            }
            return ans;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext() {
            return stack.Count != 0;
        }
    }

    /**
     * Your BSTIterator object will be instantiated and called as such:
     * BSTIterator obj = new BSTIterator(root);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
