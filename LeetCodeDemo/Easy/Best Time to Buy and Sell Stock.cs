// 121. Best Time to Buy and Sell Stock

namespace LeetCodeDemo.Easy {
    class Best_Time_to_Buy_and_Sell_Stock {
        //public static int MaxProfit(int[] prices) {
        //    int profits = 0;
        //    for (int i = 0; i < prices.Length; i++) {
        //        for (int j = i; j < prices.Length; j++) {
        //            if (prices[j] >= prices[i]) {
        //                int p = prices[j] - prices[i];
        //                profits = profits > p ? profits : p;
        //            } else
        //                break;
        //        }
        //    }
        //    return profits;
        //}

        public int MaxProfit(int[] prices) {
            int maxProfit = 0;
            int minBuyIn = int.MaxValue;
            for (int i = 0; i < prices.Length; i++) {
                if (prices[i] < minBuyIn) {
                    minBuyIn = prices[i];
                } else {
                    if (prices[i] - minBuyIn > maxProfit)
                        maxProfit = prices[i] - minBuyIn;
                }
            }
            return maxProfit;
        }
    }
}
