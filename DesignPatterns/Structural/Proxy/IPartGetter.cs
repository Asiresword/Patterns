using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Proxy
{
    public interface IPartGetter : IDisposable
    {
        Part GetPartByName(string Name);
    }
}
