using InterpreterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Classes
{
    public class TerminalExpression : IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.ToUpper().Contains(data.ToUpper()))
                return true;
            else
                return false;
        }
    }
}
