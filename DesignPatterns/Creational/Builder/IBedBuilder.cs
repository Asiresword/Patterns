using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Builder
{
    public interface IBedBuilder
    {
        void AddCarcass();
        void AddMattress();
        void AddPillows();
        void AddBlanket();

        Bed GetBed();
        void Clear();
    }
}
