// 908. Smallest Range I

using System.Linq;

namespace LeetCodeDemo.Easy
{
    class SmallestRangeI
    {
        public static int Smallest_Range_I(int[] A, int K)
        {
            int result = A.Max() - K - (A.Min() + K);
            return result > 0 ? result : 0;
        }
    }
}
