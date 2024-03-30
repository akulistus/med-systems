using System.Collections.Generic;

namespace FirstProject.model
{
    internal class ExpressionParser
    {
        private Dictionary<char, int> operatorPriority = new()
        {
            {'(', 0},
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
            {'^', 3},
            {'~', 4}
        };

        private string GetStringNumber(string expression, ref int pos)
        {
            string strNumber = "";

            for (; pos < expression.Length; pos++)
            {
                char num = expression[pos];
                if (!(Char.IsDigit(num) || num == ','))
                {
                    pos --;
                    break;
                }

                strNumber += num;
            }
            return strNumber;
        }

        private List<string> ToPostfixExpr(string infixExpr)
        {
            List<string> postfixExpr = new();
            Stack<char> operatorsStack = new();

            for (int i = 0; i < infixExpr.Length; i++)
            {
                char c = infixExpr[i];

                if (Char.IsDigit(c))
                {
                    postfixExpr.Add(GetStringNumber(infixExpr, ref i));
                }
                else if (c == '(')
                {
                    operatorsStack.Push(c);
                }
                else if (c == ')')
                {
                    while (operatorsStack.Count > 0 && operatorsStack.Peek() != '(')
                    {
                        postfixExpr.Add(operatorsStack.Pop().ToString());
                    }
                    if (operatorsStack.Count > 0)
                    {
                        operatorsStack.Pop();
                    }
                }
                else if (operatorPriority.ContainsKey(c))
                {
                    char op = c;
                    if (op == '-' && (i == 0 || (i > 1 && operatorPriority.ContainsKey(infixExpr[i-1]))))
                    {
                        op = '~';
                    }
                    while (operatorsStack.Count > 0 && (operatorPriority[operatorsStack.Peek()] >= operatorPriority[op]))
                    {
                        postfixExpr.Add(operatorsStack.Pop().ToString());
                    }
                    operatorsStack.Push(op);
                }
            }

            foreach (char op in operatorsStack)
            {
                postfixExpr.Add(op.ToString());
            }
            return postfixExpr;
        }

        private double Execute(char op, double first, double second)
        {
            return op switch
            {
                '+' => first + second,
                '-' => first - second,
                '*' => first * second,
                '/' => first / second,
                '^' => Math.Pow(first, second),
                _ => 0
            };
        }

        private double CalculatePostfix(List<string> postfixExpr)
        {
            Stack<double> nums = new();
            int counter = 0;

            foreach (string c in postfixExpr)
            {
                if (c.Length > 1 || Char.IsDigit(Convert.ToChar(c)))
                {
                    nums.Push(Convert.ToDouble(c));
                    continue;
                }
                counter++;
                if (c == "~")
                {
                    double last = nums.Count > 0 ? nums.Pop() : 0;
                    nums.Push(Execute('-', 0, last));
                    continue;
                }

                if (nums.Count > 1)
                {
                    double second = nums.Pop(),
                    first = nums.Pop();
                    nums.Push(Execute(Convert.ToChar(c), first, second));
                }
            }

            if (nums.Count > 0)
            {
                return nums.Pop();
            }
            return 0;
        }

        public string Calculate(string expression)
        {
            List<string> postfixExpr = ToPostfixExpr(expression);
            double result = CalculatePostfix(postfixExpr);
            return result.ToString();
        }
    }
}
