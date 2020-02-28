using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Prototype
{
    public class BookPaper : IPaper
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public BookPaper(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public BookPaper() : this(13, 20) { }

        public string PaperInfo() => $"[BookPaper]: Width: {this.Width} | Height: {this.Height}";
        public IPaper Clone() => new BookPaper(this.Width, this.Height); 
    }
}
