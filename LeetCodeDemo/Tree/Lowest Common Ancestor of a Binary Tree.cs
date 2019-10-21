// 236. Lowest Common Ancestor of a Binary Tree


namespace LeetCodeDemo.Tree {
    class Lowest_Common_Ancestor_of_a_Binary_Tree {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null || root.val == p.val || root.val == q.val)
                return root;
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            if (left == null && right == null) return null;
            if (left != null && right == null) return left;
            if (left == null && right != null) return right;
            return root;
        }

        
    }
}
