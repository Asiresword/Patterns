﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Strategy
{
    public class CSLanguage : ILanguage
    {
        public string Write() => "Writing in C# language";
    }
}
