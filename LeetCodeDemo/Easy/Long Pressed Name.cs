// 925. Long Pressed Name

namespace LeetCodeDemo.Easy
{
    class Long_Pressed_Name
    {
        public static bool IsLongPressedName(string name, string typed)
        {
            int i = 0;
            foreach (char ch in name.ToCharArray())
            {
                if (i == typed.Length)
                    return false;
                if (typed[i] != ch)
                {
                    if (i == 0 || typed[i] != typed[i - 1])
                        return false;
                    while (i < typed.Length && typed[i] == typed[i - 1])
                        i++;
                    if (i == typed.Length || typed[i] != ch) return false;
                }
                i++;
            }
            return true;
        }


    }
}
