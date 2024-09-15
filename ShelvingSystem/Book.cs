using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal class Book:Good
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        
        public Book(int id, int width, int height, int lenght) : base(id)
        {
            Width = width;
            Height = height;
            Length = lenght;
            
        }

        public override string Description()
        {
            return $"#{id}: Book {Width}x{Height}x{Length}";
        }

        public override string Kurzzeichen()
        {
            return "B";
        }
    }
}
