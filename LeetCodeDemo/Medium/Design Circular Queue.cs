

namespace LeetCodeDemo.Medium
{
    class Design_Circular_Queue
    {
    }
    public class MyCircularQueue
    {
        int[] que;
        int front;
        int rear;
        int Count;
        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            que = new int[k];
            front = 1;
            rear = 0;
            Count = 0;
        }

        public int Succ(int num)
        {
            if (++num == que.Length)
                num = 0;
            return num;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            que[rear = Succ(rear)] = value;
            Count++;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            front = Succ(front);
            Count--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            return IsEmpty() ? -1 : que[front];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            return IsEmpty() ? -1 : que[rear];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return Count == que.Length;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
