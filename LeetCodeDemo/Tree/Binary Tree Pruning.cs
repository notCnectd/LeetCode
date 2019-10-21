// 814. Binary Tree Pruning

namespace LeetCodeDemo.Tree {
    class Binary_Tree_Pruning {
        public TreeNode PruneTree(TreeNode root) {
            if (root == null) return null;
            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if(root.left==null&& root.right == null && root.val != 1) {
                root = null;
            }
            return root;
        }
    }
}
