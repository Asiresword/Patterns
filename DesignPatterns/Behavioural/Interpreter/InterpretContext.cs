using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Interpreter
{
    public class InterpretContext
    {
        private Dictionary<string, int> Values { get; set; }
        public InterpretContext()
        {
            this.Values = new Dictionary<string, int>();
        }

        public int GetValue(string Key)
        {
            return Values[Key];
        }

        public void SetVariable(string Key, int Value)
        {
            if (this.Values.ContainsKey(Key))
            {
                this.Values[Key] = Value;
            }
            else
            {
                this.Values.Add(Key, Value);
            }
        }
    }
}
