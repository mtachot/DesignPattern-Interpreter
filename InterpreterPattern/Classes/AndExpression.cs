using InterpreterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Classes
{
    public class AndExpression : IExpression
    {
        private IExpression expr1 = null;
        private IExpression expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return this.expr1.Interpret(context) && this.expr2.Interpret(context);
        }
    }
}
