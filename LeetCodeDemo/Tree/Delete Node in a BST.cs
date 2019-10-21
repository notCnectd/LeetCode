// 450. Delete Node in a BST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    class Delete_Node_in_a_BST {
        public static TreeNode DeleteNode(TreeNode root, int key) {
            TreeNode tmp;
            if (root == null) return root;
            // Go left
            else if (root.val > key)
                root.left = DeleteNode(root.left, key);
            // Go right
            else if (root.val < key)
                root.right = DeleteNode(root.right, key);
            // Two children
            else if(root.left != null && root.right != null) {
                tmp = FindMin(root.right);
                root.val = tmp.val;
                root.right = DeleteNode(root.right, root.val);
            // One or zero children
            } else {
                tmp = root;
                if (root.left == null)
                    root = root.right;
                else if (root.right == null)
                    root = root.left;
                tmp = null;
            }
            return root;
            
        }

        //private TreeNode DeleteMin(TreeNode tmp) {
        //    tmp = 
        //}

        private static TreeNode FindMin(TreeNode root) {
            if (root == null || root.left == null)
                return root;
            else return FindMin(root.left);
        }
    }
}
