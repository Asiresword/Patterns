using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Prototype
{
    public class PrintablePaper : IPaper
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public PrintablePaper(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public PrintablePaper() : this(21, 30) { }

        public string PaperInfo() => $"[PrintablePaper]: Width: {this.Width} | Height: {this.Height}";
        public IPaper Clone() => new BookPaper(this.Width, this.Height);
    }
}
