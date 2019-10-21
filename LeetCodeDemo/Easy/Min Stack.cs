// 155. Min Stack
using System;
using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Min_Stack
    {
    }


    public class MinStack
    {
        Stack<int> stack;
        int min;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<int>();
            min = Int32.MaxValue;
        }

        public void Push(int x)
        {
            if(min >= x)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            if (stack.Count != 0 && stack.Pop() == min) min = stack.Pop(); 
        }

        public int Top()
        {
            return stack.Peek();
            throw new Exception("Stack is empty.");
        }

        public int GetMin()
        {
            return min;
            throw new Exception("Stack is empty");
        }
    }

}
