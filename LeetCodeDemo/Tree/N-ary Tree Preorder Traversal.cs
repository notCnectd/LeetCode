// 589. N-ary Tree Preorder Traversal

using System.Collections.Generic;

namespace LeetCodeDemo.Tree
{
    class N_ary_Tree_Preorder_Traversal
    {
        // Non-recursive
        //public IList<int> Preorder(Node root)
        //{
        //    IList<int> res = new List<int>();
        //    if (root == null) return res;
        //    Stack<Node> stack = new Stack<Node>();
        //    stack.Push(root);
        //    while (stack.Count != 0)
        //    {
        //        Node node = stack.Pop();
        //        res.Add(node.val);
        //        for (int i = node.children.Count - 1; i >= 0; i--)
        //            stack.Push(node.children[i]);
        //    }
        //    return res;
        //}

        public IList<int> Preorder(Node root)
        {
            IList<int> res = new List<int>();
            if (root == null) return null;
            Helper(root, res);
            return res;
            
        }

        public void Helper(Node root, IList<int> list)
        {
            if (root == null) return;
            list.Add(root.val);
            foreach (Node node in root.children)
                Helper(node, list);
        }
    }
}
