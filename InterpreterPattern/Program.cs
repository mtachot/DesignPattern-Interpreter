using InterpreterPattern.Classes;
using InterpreterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        // Rule : Robert and John are male
        public static IExpression getMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");

            return new OrExpression(robert, john);
        }

        // Rule : Julie is a married woman
        public static IExpression getMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("married");

            return new AndExpression(julie, married);
        }

        public static void Main(string[] args)
        {
            IExpression isMale = getMaleExpression();
            IExpression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine(String.Format("Is John a male ? {0}", isMale.Interpret("John")));
            Console.WriteLine(String.Format("Is Julie a married woman ? {0}", isMarriedWoman.Interpret("Julie Married")));
            Console.ReadLine();
        }
    }
}
