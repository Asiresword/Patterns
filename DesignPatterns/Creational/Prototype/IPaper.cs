using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Prototype
{
    public interface IPaper
    {
        IPaper Clone();
        string PaperInfo();
    }
}
