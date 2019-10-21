// 657. Robot Return to Origin

namespace LeetCodeDemo.Easy
{
    class Robot_Return_to_Origin
    {
        public static bool JudgeCircle(string moves)
        {
            int L = 0, R = 0, U = 0, D = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L') L++;
                else if (moves[i] == 'R') R++;
                else if (moves[i] == 'U') U++;
                else if (moves[i] == 'D') D++;
            }
            return L == R && U == D; 
        }
    }
}
