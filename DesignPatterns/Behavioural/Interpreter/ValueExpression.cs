using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Interpreter
{
    public class ValueExpression : IExpression
    {
        private string Key { get; set; }
        public ValueExpression(string Key)
        {
            this.Key = Key;
        }
        public int Interpretate(InterpretContext Context)
        {
            return Context.GetValue(this.Key);
        }
    }
}
