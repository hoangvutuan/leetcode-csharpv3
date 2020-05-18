using System;
using System.Collections;

namespace ValidParentheses
{
    class MainClass
    {


            public static bool IsValid(string s)
            {
                Stack stack = new Stack();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '{')
                    {
                        stack.Push('}');
                    }
                    else if (s[i] == '[')
                    {
                        stack.Push(']');
                    }
                    else if (s[i] == '(')
                    {
                        stack.Push(')');
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        char c = (char)stack.Pop();
                        if (c != s[i])
                        {
                            return false;
                        }
                    }
                }
                return stack.Count == 0;

            }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World5!");
            string input = "()";
            bool res = IsValid(input);
            Console.Write("Result:" + res);
        }
    }
}
