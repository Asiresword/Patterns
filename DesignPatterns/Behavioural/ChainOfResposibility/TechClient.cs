using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public class TechClient
    {
        public bool FirstLine { get; set; }
        public bool SecondLine { get; set; }
        public bool ThirdLine { get; set; }

        public TechClient(bool FirstLine, bool SecondLine, bool ThirdLine)
        {
            this.FirstLine = FirstLine;
            this.SecondLine = SecondLine;
            this.ThirdLine = ThirdLine;
        }
        public TechClient() : this(true, false, false) { }
    }
}
