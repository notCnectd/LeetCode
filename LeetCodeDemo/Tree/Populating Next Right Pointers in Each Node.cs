// 116. Populating Next Right Pointers in Each Node

namespace LeetCodeDemo.Tree {
    class Populating_Next_Right_Pointers_in_Each_Node {
        public Node Connect(Node root) {
            if (root == null) return null;
            root.next = null;
            Helper(root);
            return root;
        }

        public void Helper(Node root) {
            if (root == null) return;
            if (root.left == null) return;
            root.left.next = root.right;
            if (root.next != null) {
                root.right.next = root.next.left;
            } else {
                root.right.next = null;
            }
            Helper(root.left);
            Helper(root.right);
        }
    }
}
