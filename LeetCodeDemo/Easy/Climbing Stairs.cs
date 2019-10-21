// 70. Climbing Stairs

namespace LeetCodeDemo.Easy {
    class Climbing_Stairs {
        public int ClimbStairs(int n) {
            int before = 0, after = 1;
            int ways = 0;
            for (int i = 0; i < n; i++) {
                ways = before + after;
                before = after;
                after = ways;
            }
            return ways;
        }
    }
}
