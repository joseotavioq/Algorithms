using System.Collections.Generic;

namespace Algorithms.Stacks
{
    public class ValidParentheses
    {
        public bool FirstTry(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0)
                {
                    char last = stack.Peek();

                    if ((last == '(' && c == ')')
                        || (last == '{' && c == '}')
                        || (last == '[' && c == ']'))
                    {
                        stack.Pop();
                        continue;
                    }

                    if (last == '(' || last == '{' || last == '[')
                        if (c == ')' || c == '}' || c == ']')
                            return false;
                }

                stack.Push(c);
            }

            return stack.Count == 0;
        }
    }
}