// 590. N-ary Tree Postorder Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree {
    class N_ary_Tree_Postorder_Traversal {
        public IList<int> Postorder(Node root) {
            Stack<Node> stack = new Stack<Node>();
            Stack<Node> outPut = new Stack<Node>();
            IList<int> res = new List<int>();
            if (root == null) return res;
            stack.Push(root); 
            while (stack.Count > 0) {
                Node node = stack.Pop();
                outPut.Push(node);
                foreach (Node n in node.children) {
                    stack.Push(n);
                }
            }
            while (outPut.Count > 0) {
                res.Add(outPut.Pop().val);
            }
            return res;
        }
    }
}
