﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Interpreter
{
    public class AddExpression : IExpression
    {
        private IExpression Left { get; set; }
        private IExpression Right { get; set; }
        public AddExpression(IExpression Left, IExpression Right)
        {
            this.Left = Left;
            this.Right = Right;
        }

        public int Interpretate(InterpretContext Context) 
        {
            return Left.Interpretate(Context) + Right.Interpretate(Context);
        }
    }
}
