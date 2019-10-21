// 682. Baseball Game


namespace LeetCodeDemo.Easy
{
    class Baseball_Game
    {
        public static int CalPoints(string[] ops)
        {
            int score = 0;
            int[] stack = new int[ops.Length];
            int top = -1;
            foreach(string str in ops)
            {

                if (str == "C") top--;
                else if (str == "D")
                {                   
                    stack[top + 1] = stack[top] * 2;
                    ++top;
                }
                else if (str == "+")
                {
                    stack[top + 1] = stack[top - 1] + stack[top];
                    ++top;
                }
                else stack[++top] = int.Parse(str);
            }
            for (int i = 0; i <= top; i++) score += stack[i];
            return score;
        }
    }
}
