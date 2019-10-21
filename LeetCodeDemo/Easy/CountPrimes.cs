// Count the number of prime numbers less than a non-negative number, n.

// Example:
// Input: 10
// Output: 4
// Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.

namespace LeetCodeDemo.Easy
{
    class CountPrimes
    {
        public static int Count_Primes(int n)
        {
            if (n <= 1) return 0;
            bool[] isNotPrimes = new bool[n + 1];
            for (int i = 2; i * i <= n; i++)
            {
                for (int j = i * i; j < n; j += i)
                {
                    isNotPrimes[j] = true;
                }
            }
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (isNotPrimes[i])
                {
                    count++;
                }
            }
            return n - 2 - count;
        }
    }
}
