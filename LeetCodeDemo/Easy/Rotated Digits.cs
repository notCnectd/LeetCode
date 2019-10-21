// 788. Rotated Digits

namespace LeetCodeDemo.Easy
{
    class Rotated_Digits
    {
        //public static int RotatedDigits(int N)
        //{

        //    int count = 0;
        //    for (int i = 2; i <= N; i++)
        //    { 
        //        string num = i.ToString();
        //        if (num.Contains("2") || num.Contains("5") || num.Contains("6") || num.Contains("9"))
        //            if (!num.Contains("3") && !num.Contains("4") && !num.Contains("7")) count++;                
        //    }
        //    return count;
        //}

        public static int RotatedDigits(int N)
        {
            int[] moded = { 0, 0, 1, -1, -1, 1, 1, -1, 0, 1 };
            int count = 0;
            for (int i = 2; i <= N; i++)
            {
                int j = i, flag = 0;
                while (j != 0)
                {                    
                    flag |= moded[j % 10] ;
                    j /= 10;
                }
                if (flag > 0) count++; 
            }
            return count;
        }
    }
}
