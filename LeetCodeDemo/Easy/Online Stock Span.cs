// 901. Online Stock Span

using System.Collections.Generic;

namespace LeetCodeDemo.Easy
{
    class Online_Stock_Span
    {
    }

    public class StockSpanner
    {
        Stack<int> prices, span;
        public StockSpanner()
        {
            prices = new Stack<int>();
            span = new Stack<int>();
        }

        public int Next(int price)
        {
            int days = 1;
            while(prices.Count != 0 && prices.Peek() <= price)
            {
                prices.Pop();
                days += span.Pop();
            }
            prices.Push(price);
            span.Push(days);
            return days;
        }
    }
}
