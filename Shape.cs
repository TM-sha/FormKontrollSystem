using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract double BeregnAreal();
    }
}
