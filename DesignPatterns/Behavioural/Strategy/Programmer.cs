using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Strategy
{
    public class Programmer
    {
        private ILanguage language { get; set; }
        public Programmer(ILanguage lang)
        {
            this.language = lang;
        }

        public void WriteProgram()
        {
            Console.WriteLine(language.Write());
        }

        public void SetLanguage(ILanguage lang)
        {
            this.language = lang;
        }
    }
}
