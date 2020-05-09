using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stacks
{
    public class EvaluateExpression
    {
        public int FirstTry(string expression)
        {
            Stack<int> numbers = new Stack<int>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+'
                    || expression[i] == '-'
                    || expression[i] == '*'
                    || expression[i] == '/')
                    operators.Push(expression[i]);
                else if (expression[i] >= '0' && expression[i] <= '9')
                    numbers.Push(expression[i] - '0');
                else if (expression[i] == ')')
                {
                    int b = numbers.Pop();
                    int a = numbers.Pop();
                    char op = operators.Pop();
                    numbers.Push(calculate(a, b, op));
                }
            }

            if (numbers.Count == 1)
                return numbers.Pop();
            else
                return 0;
        }

        private int calculate(int a, int b, char op)
        {
            if (op == '+')
                return a + b;
            else if (op == '-')
                return a - b;
            else if (op == '*')
                return a * b;
            else
                return a / b;
        }
    }
}
