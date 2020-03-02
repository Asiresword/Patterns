using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Interpreter
{
    public interface IExpression
    {
        int Interpretate(InterpretContext Context);
    }
}
