// 71. Simplify Path

using System.Collections.Generic;

namespace LeetCodeDemo.Medium
{
    class Simplify_Path
    {
        //public static string SimplifyPath(string path)
        //{
        //    if (path == "") return "/";
        //    Stack<char> stack = new Stack<char>();
        //    string res = "";
        //    stack.Push(path[0]);
        //    for (int i = 1; i < path.Length; i++)
        //    {
        //        if (path[i] != '/' && path[i] != '.') stack.Push(path[i]);
        //        else if (path[i] == '/')
        //        {
        //            if (stack.Count == 0) stack.Push(path[i]);
        //            else if (stack.Peek() != '/') stack.Push(path[i]);
        //        }
        //        else
        //        {
        //            if (path[i] == '.' && i + 2 < path.Length && path[i + 1] == '.' && path[i + 2] == '/')
        //            {                       
        //                stack.Pop();
        //                if (stack.Count != 0)
        //                    while (stack.Peek() != '/') stack.Pop();
        //                i++;
        //            }
        //            else if (path[i] == '.' && i + 2 < path.Length && path[i + 1] == '.' && path[i + 2] != '/')
        //            {
        //                stack.Push(path[i]);
        //                stack.Push(path[++i]);
        //                stack.Push(path[++i]);
        //            }
        //            else if (path[i] == '.' && i + 2 == path.Length && path[i + 1] == '.')
        //            {
        //                stack.Pop();
        //                if (stack.Count != 0)
        //                    while (stack.Peek() != '/') stack.Pop();
        //            }
        //            else if (path[i] == '.' && i + 1 < path.Length && path[i + 1] != '.' && path[i + 1] != '/')
        //            {
        //                stack.Push(path[i]);
        //                stack.Push(path[++i]);
        //            }
        //        }
        //    }
        //    if (stack.Count == 0) return "/";
        //    if (stack.Peek() == '/' && stack.Count != 1) stack.Pop();
        //    while (stack.Count != 0) res = stack.Pop() + res;
        //    return res;
        //}

        public static string SimplifyPath(string path)
        {
            string res = "";
            Stack<string> stack = new Stack<string>();
            foreach(string str in path.Split('/'))
            {
                if (str.Equals(".."))
                {
                    if (stack.Count != 0) stack.Pop();                    
                }else if (!str.Equals(".") && str != "") stack.Push(str);
            }
            foreach (string str in stack) res = "/" + str + res;
            return res == "" ? "/" : res;
        }
    }
}
