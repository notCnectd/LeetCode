// 122. Best Time to Buy and Sell Stock II

namespace LeetCodeDemo.Easy {
    class Best_Time_to_Buy_and_Sell_Stock_II {
        // 峰谷法
        // 计算每个相邻的谷值和峰值之差再相加
        // public int MaxProfit(int[] prices) {
        //     int profits = 0;
        //     int i = 0;
        //     int valley = 0;
        //     int peak = 0;
        //     int len = prices.Length;
        //     while (i < len - 1) {
        //         while (i < len - 1 && prices[i] >= prices[i + 1])
        //             i++;
        //         valley = prices[i];
        //         while (i < len - 1 && prices[i] <= prices[i + 1])
        //             i++;
        //         peak = prices[i];
        //         profits += (peak - valley);
        //     }
        //     return profits;
        // }

        public int MaxProfit(int[] prices) {
            if (prices.Length <= 1) return 0;
            int profits = 0;
            // 总利润 = 上升路径之和
            for (int i = 1; i < prices.Length; i++) {
                if (prices[i] > prices[i - 1])
                    profits += prices[i] - prices[i - 1];
            }
            return profits;
        }
    }
}
