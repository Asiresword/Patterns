using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Strategy
{
    public class JSLanguage : ILanguage
    {
        public string Write() => "Writing in JS language";
    }
}
