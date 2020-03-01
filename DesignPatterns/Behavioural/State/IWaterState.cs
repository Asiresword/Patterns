using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.State
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
