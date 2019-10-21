// 623. Add One Row to Tree


namespace LeetCodeDemo.Tree {
    class Add_One_Row_to_Tree {
        public TreeNode AddOneRow(TreeNode root, int v, int d) {
            if (d == 1) {
                TreeNode node = new TreeNode(v) {
                    left = root
                };
                return node;
            }
            return Helper(root, v, d, 1);

        }

        private TreeNode Helper(TreeNode root, int v, int d, int depth) {
            if (root == null) return null;
            if (d == depth + 1) {
                if (root.left != null) {
                    TreeNode node = new TreeNode(v) {
                        left = root.left
                    };
                    root.left = node;
                } else {
                    root.left = new TreeNode(v);
                }
                if (root.right != null) {
                    TreeNode node = new TreeNode(v) {
                        right = root.right
                    };
                    root.right = node;
                } else {
                    root.right = new TreeNode(v);
                }
                return root;
            }
            root.left = Helper(root.left, v, d, depth + 1);
            root.right = Helper(root.right, v, d, depth + 1);
            return root;
        }
    }
}
