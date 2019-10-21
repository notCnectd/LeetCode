// 168. Excel Sheet Column Title

namespace LeetCodeDemo.Easy
{
    class ExcelSheetColumnTitle
    {
        public static string ConvertToTitle(int n)
        {
            string result = "";
            while (n > 0)
            {
                int temp = n % 26;
                n /= 26;
                if (temp == 0)
                {
                    result = 'Z' + result;
                    n -= 1;
                }
                else
                {
                    result = (char)(temp + 'A' - 1) + result;
                }              
            }
            return result;
        }
    }
}
