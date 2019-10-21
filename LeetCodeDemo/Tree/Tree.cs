using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Tree {


    // BinaryTree
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }



    // NTree
    //public class Node {
    //    public int val;
    //    public IList<Node> children;

    //    public Node() { }
    //    public Node(int _val, IList<Node> _children) {
    //        val = _val;
    //        children = _children;
    //    }
    //}

    // Next BT
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;
        public IList<Node> children;

        public Node() { }
        public Node(int _val) {val = _val;}
        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }


    public class BinaryTree {

        int[] vals = { -10,9,20};
        List<TreeNode> nodeList;

        public TreeNode Create() {
            nodeList = new List<TreeNode>();
            foreach (int val in vals) {
                nodeList.Add(new TreeNode(val));
            }
            nodeList[0].left = nodeList[1];
            nodeList[0].right = nodeList[2];
            //nodeList[1].left = nodeList[3];
            //nodeList[1].right = nodeList[4];
            //nodeList[2].right = nodeList[3];
            //nodeList[2].left = nodeList[4];
            //nodeList[4].left = nodeList[6];

            return nodeList[0];
        }
    }

    public class NextNode {
        int[] vals = { 5, 3, 6, 2, 4, 7 };
        List<Node> nodeList;
        public Node Create() {
            nodeList = new List<Node>();
            foreach (int val in vals) {
                nodeList.Add(new Node(val));
            }
            nodeList[0].left = nodeList[1];
            nodeList[0].right = nodeList[8];
            nodeList[1].left = nodeList[2];
            nodeList[1].right = nodeList[4];
            nodeList[2].left = nodeList[3];
            nodeList[4].right = nodeList[6];
            nodeList[4].left = nodeList[5];
            nodeList[6].left = nodeList[7];
            nodeList[8].right = nodeList[10];
            nodeList[8].left = nodeList[9];
            nodeList[10].right = nodeList[12];
            nodeList[10].left = nodeList[11];
            return nodeList[0];
        }
    }
}
