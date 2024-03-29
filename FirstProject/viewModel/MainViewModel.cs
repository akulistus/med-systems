using System;
using System.Collections.Generic;
using System.Text;
using FirstProject;
using FirstProject.model;

namespace FirstProject.viewModel
{
    public class MainViewModel
    {
        private ExpressionParser expressionParser;

        public MainViewModel()
        {
            expressionParser = new ExpressionParser();
        }

        public string Calculate(string expression)
        {
            string result = expressionParser.Calculate(expression);
            return result;
        }
    }
}