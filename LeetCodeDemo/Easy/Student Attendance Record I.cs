// 551. Student Attendance Record I

namespace LeetCodeDemo.Easy
{
    class Student_Attendance_Record_I
    {
        public static bool CheckRecord(string s)
        {
            int A = 0, L = 0;
            for (int i = 0; i < s.Length; i++)
            {               
                while (i < s.Length && s[i] == 'L')
                {
                    i++;
                    L++;
                }
                if (i < s.Length && s[i] == 'A') A++;
                if (L > 2) return false;
                else L = 0;
            }
            return A > 1 ? false : true;
        }
    }
}
