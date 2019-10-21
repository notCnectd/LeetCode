// Given a non-negative integer num,
// repeatedly add all its digits until the result has only one digit.
//Input: 38
//Output: 2 
//Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2. 
//Since 2 has only one digit, return it.

namespace LeetCodeDemo.Easy
{
    class AddDigits
    {
        public int Add_Digits(int num)
        {
            if (num == 0) return 0;
            int re = num % 9;
            if ( re == 0 ) return 9;
            return re;
        }
    }
}
