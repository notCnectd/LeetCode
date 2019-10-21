// 117. Populating Next Right Pointers in Each Node II

namespace LeetCodeDemo.Tree {
    class Populating_Next_Right_Pointers_in_Each_Node_II {
        public static Node Connect(Node root) {
            if (root == null) return root;
            root.next = null;
            Helper(root);
            return root;
        }

        private static void Helper(Node root) {
            if (root == null) return;
            if (root.left == null && root.right == null)
                return;
            if (root.left != null) {
                if (root.right != null) root.left.next = root.right;
                else if (root.next == null) root.left.next = null;
                else {
                    Node node = root.next;
                    while (node != null && node.left == null && node.right == null) {
                        node = node.next;
                    }
                    if (node == null) root.left.next = null;
                    else if (node.left != null) root.left.next = node.left;
                    else if (node.right != null) root.left.next = node.right;
                }
            }
            if (root.right != null) {
                if (root.next == null) root.right.next = null;
                else {
                    Node node = root.next;
                    while (node != null && node.left == null && node.right == null) {
                        node = node.next;
                    }
                    if (node == null) root.right.next = null;
                    else if (node.left != null) root.right.next = node.left;
                    else if (node.right != null) root.right.next = node.right;
                }
            }
            // 注意递归的顺序要从右到左
            Helper(root.right);
            Helper(root.left);
        }
    }
}


//{"$id":"1","left":{"$id":"2","left":{"$id":"3","left":{"$id":"4","left":null,"next":null,"right":null,"val":7},"next":null,"right":null,"val":4},"next":null,"right":{"$id":"5","left":null,"next":null,"right":null,"val":5},"val":2},"next":null,"right":{"$id":"6","left":null,"next":null,"right":{"$id":"7","left":null,"next":null,"right":{"$id":"8","left":null,"next":null,"right":null,"val":8},"val":6},"val":3},"val":1}

//{"$id":"1","left":{"$id":"2","left":{"$id":"3","left":null,"next":null,"right":null,"val":4},"next":null,"right":{"$id":"4","left":null,"next":null,"right":null,"val":5},"val":2},"next":null,"right":{"$id":"5","left":null,"next":null,"right":{"$id":"6","left":null,"next":null,"right":null,"val":7},"val":3},"val":1}

    //{"$id":"1","left":{"$id":"2","left":{"$id":"3","left":{"$id":"4","left":null,"next":null,"right":null,"val":2},"next":null,"right":null,"val":0},"next":null,"right":{"$id":"5","left":{"$id":"6","left":null,"next":null,"right":null,"val":1},"next":null,"right":{"$id":"7","left":{"$id":"8","left":null,"next":null,"right":null,"val":7},"next":null,"right":null,"val":0},"val":7},"val":1},"next":null,"right":{"$id":"9","left":{"$id":"10","left":null,"next":null,"right":null,"val":9},"next":null,"right":{"$id":"11","left":{"$id":"12","left":null,"next":null,"right":null,"val":8},"next":null,"right":{"$id":"13","left":null,"next":null,"right":null,"val":8},"val":1},"val":3},"val":2}

