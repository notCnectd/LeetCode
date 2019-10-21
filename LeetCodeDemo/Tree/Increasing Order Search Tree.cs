// 897. Increasing Order Search Tree

namespace LeetCodeDemo.Tree {
    class Increasing_Order_Search_Tree {
        // Solution 1
        //TreeNode node;
        //public TreeNode IncreasingBST(TreeNode root) {
        //    TreeNode res = new TreeNode(0);
        //    node = res;
        //    InOrderTrav(root);
        //    return res.right;
        //}

        //public void InOrderTrav(TreeNode root) {
        //    if (root == null) return;
        //    InOrderTrav(root.left);
        //    root.left = null;
        //    node.right = root;
        //    node = root;
        //    InOrderTrav(root.right);          
        //}

        // Solution 2
        //public TreeNode IncreasingBST(TreeNode root) {
        //    ArrayList list = new ArrayList();
        //    InOrder(root, list);
        //    TreeNode res = new TreeNode(0), node = res;
        //    foreach (int n in list) {
        //        node.right = new TreeNode(n);
        //        node = node.right;
        //    }
        //    return res.right;
        //}

        //public void InOrder(TreeNode root, ArrayList list) {
        //    if (root != null) {
        //        InOrder(root.left, list);
        //        list.Add(root.val);
        //        InOrder(root.right, list);
        //    }
        //}

        // Solution 3
        public TreeNode IncreasingBST(TreeNode root) {
            TreeNode res = root;
            // 连接右子树
            if (root.right != null)
                root.right = IncreasingBST(root.right);
            // 连接左子树
            if (root.left != null) {
                // 递归到无左子树的节点，根节点为其父节点
                res = IncreasingBST(root.left);
                // 节点的最右节点连接其父节点
                TreeNode node = res;
                while (node.right != null) node = node.right;
                node.right = root;
                root.left = null;
            }
            return res;
        }
    }
}
