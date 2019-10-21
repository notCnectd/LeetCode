// 701. Insert into a Binary Search Tree


namespace LeetCodeDemo.Tree {
    class Insert_into_a_Binary_Search_Tree {
        public TreeNode InsertIntoBST(TreeNode root, int val) {
            if(root == null) {
                root = new TreeNode(val);
                root.left = root.right = null;
            }
            if (val < root.val) root.left = InsertIntoBST(root.left, val);
            if (val > root.val) root.right = InsertIntoBST(root.right, val);
            return root;
        }
    }
}
