using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string name, string color)
        {
            Name = name;
            Color = color;
            Radius = radius;
        }
        public override double BeregnAreal()
        {
            double R2 = Radius * Radius;
            double Pi = Math.PI;
            double Areal = R2 * Pi;

            return Areal;
        }
    }
}
