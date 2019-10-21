// 99. Recover Binary Search Tree

namespace LeetCodeDemo.Tree {
    class Recover_Binary_Search_Tree {
        TreeNode mis1 = null, mis2 = null;
        public void RecoverTree(TreeNode root) {
            Helper(root);
            int tmp;
            tmp = mis1.val;
            mis1.val = mis2.val;
            mis2.val = tmp;
        }

        private void Helper(TreeNode root) {
            if (root == null) return;
            Helper(root.left);
            if (mis1 == null)
                mis1 = root;
            else if (mis1.val > root.val)
                mis2 = root;
            else {
                if (mis2 == null)
                    mis1 = root;
                else
                    return;
            }
            Helper(root.right);
        }

        
    }
}
