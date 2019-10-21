// 235. Lowest Common Ancestor of a Binary Search Tree
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {
    class Lowest_Common_Ancestor_of_a_Binary_Search_Tree {
        // Recursive
        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //    TreeNode node = root;
        //    if (p.val > node.val && q.val > node.val)
        //        return LowestCommonAncestor(root.right, p, q);
        //    if (p.val < node.val && q.val < node.val)
        //        return LowestCommonAncestor(root.left, p, q);
        //    return node;
        //}

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            TreeNode node = root;
            while (node != null) {
                if (p.val < node.val && q.val < node.val)
                    node = node.left;
                else if (p.val > node.val && q.val > node.val)
                    node = node.right;
                else return node;
            }
            return null;
        }
    }
}
