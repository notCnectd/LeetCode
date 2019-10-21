// 232.Implement Queue using Stacks

using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Implement_Queue_using_Stacks
    {
    }

    public class MyQueue
    {
        Stack<int> sta;
        Stack<int> stb;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            sta = new Stack<int>();
            stb = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            sta.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            
            int front;
            while (sta.Count != 0) stb.Push(sta.Pop());
            front = stb.Pop();
            while (stb.Count != 0) sta.Push(stb.Pop());
            return front;                      
        }

        /** Get the front element. */
        public int Peek()
        {
            int front;
            while (sta.Count != 0) stb.Push(sta.Pop());
            front = stb.Peek();
            while (stb.Count != 0) sta.Push(stb.Pop());
            return front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return sta.Count == 0 ? true : false;
        }
    }

    public class MyQueue2
    {
        Stack<int> sta;
        Stack<int> stb;
        int front;
        /** Initialize your data structure here. */
        public MyQueue2()
        {
            sta = new Stack<int>();
            stb = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if(sta.Count == 0) front = x;
            sta.Push(x);

        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if(stb.Count == 0)
            {
                while(sta.Count != 0) stb.Push(sta.Pop());                    
            }
            return stb.Pop();           
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stb.Count != 0) return stb.Peek();
            return front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return sta.Count == 0 && stb.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
