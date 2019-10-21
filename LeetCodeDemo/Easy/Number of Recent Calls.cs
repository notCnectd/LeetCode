// 933. Number of Recent Calls

using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Number_of_Recent_Calls
    {
    }

    public class RecentCounter
    {
        Queue<int> queue;
        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (queue.Peek() < t - 3000)
                queue.Dequeue();
            return queue.Count;
        }
    }

}
