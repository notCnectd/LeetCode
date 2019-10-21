// 225. Implement Stack using Queues
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Easy
{
    class Implement_Stack_using_Queues
    {
    }
    public class MyStack
    {
        Queue<int> q1;
        Queue<int> q2;
        int temp;
        /** Initialize your data structure here. */
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q1.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {           
            while (q1.Count > 1) q2.Enqueue(q1.Dequeue());
            temp = q1.Dequeue();
            while (q2.Count != 0) q1.Enqueue(q2.Dequeue());
            return temp;
        }

        /** Get the top element. */
        public int Top()
        {
            while (q1.Count > 1) q2.Enqueue(q1.Dequeue());
            temp = q1.Peek();
            q2.Enqueue(q1.Dequeue());
            while (q2.Count != 0) q1.Enqueue(q2.Dequeue());
            return temp;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
