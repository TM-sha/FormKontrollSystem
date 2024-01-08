using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Triangle : Shape
    {
        public double Base { get; set; }
        public double Høyde { get; set; }

        public Triangle(double @base, double høyde, string color, string name)
        {
            Name = name;
            Color = color;
            Base = @base;
            Høyde = høyde;
        }
        public override double BeregnAreal()
        {
            return Base * Høyde /** Høyde*/;
        }
    }
}
