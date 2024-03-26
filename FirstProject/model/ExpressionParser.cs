using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.model
{
    internal class ExpressionParser
    {
        private string expression;
        public List<string> test;
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
        public ExpressionParser(string expression)
        {
            this.expression = expression;
            test = ToPostfixExpr(expression);
        }

        private string GetStringNumber(string expression, ref int pos)
        {
            string strNumber = "";

            for (; pos < expression.Length; pos++)
            {
                char num = expression[pos];
                if (!(Char.IsDigit(num) || num == '.'))
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
                    operatorsStack.Pop();
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
    }
}
