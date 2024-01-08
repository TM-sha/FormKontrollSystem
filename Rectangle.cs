using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, string name, string color)
        {
            Name = name;
            Color = color;
            Length = length;
            Width = width;
        }
        public override double BeregnAreal()
        {
            return Length * Width;
        }
    }
}
