using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo.Medium
{
    class Design_Circular_Deque
    {
    }
    public class MyCircularDeque
    {
        int[] que;
        int front;
        int rear;
        int Count;
        /** Initialize your data structure here. Set the size of the deque to be k. */
        public MyCircularDeque(int k)
        {
            que = new int[k];
            front = 1;
            rear = 0;
            Count = 0;
        }

        public int SuccE(int num)
        {
            if (--num == -1)
                num = que.Length - 1;
            return num;
        } 

        public int SuccF(int num)
        {
            if (++num == que.Length)
                num = 0;
            return num;
        }

        /** Adds an item at the front of Deque. Return true if the operation is successful. */
        public bool InsertFront(int value)
        {
            if (Count == que.Length) return false;
            que[front = SuccE(front)] = value;
            Count++;
            return true;
        }

        /** Adds an item at the rear of Deque. Return true if the operation is successful. */
        public bool InsertLast(int value)
        {
            if (Count == que.Length) return false;
            que[rear = SuccF(rear)] = value;
            Count++;
            return true;
        }

        /** Deletes an item from the front of Deque. Return true if the operation is successful. */
        public bool DeleteFront()
        {
            if (Count == 0) return false;
            front = SuccF(front);
            Count--;
            return true;
        }

        /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
        public bool DeleteLast()
        {
            if (Count == 0) return false;
            rear = SuccE(rear);
            Count--;
            return true;
        }

        /** Get the front item from the deque. */
        public int GetFront()
        {
            return IsEmpty() ? -1 : que[front];
        }

        /** Get the last item from the deque. */
        public int GetRear()
        {
            return IsEmpty() ? -1 : que[rear];
        }

        /** Checks whether the circular deque is empty or not. */
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /** Checks whether the circular deque is full or not. */
        public bool IsFull()
        {
            return Count == que.Length;
        }
    }

    /**
     * Your MyCircularDeque object will be instantiated and called as such:
     * MyCircularDeque obj = new MyCircularDeque(k);
     * bool param_1 = obj.InsertFront(value);
     * bool param_2 = obj.InsertLast(value);
     * bool param_3 = obj.DeleteFront();
     * bool param_4 = obj.DeleteLast();
     * int param_5 = obj.GetFront();
     * int param_6 = obj.GetRear();
     * bool param_7 = obj.IsEmpty();
     * bool param_8 = obj.IsFull();
     */
}
