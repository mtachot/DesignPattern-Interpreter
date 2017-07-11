using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Interfaces
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
