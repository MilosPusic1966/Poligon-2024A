using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024A
{
    internal class Tacka
    {
        public double x, y;
        public Tacka() { }
        public Tacka(double _x, double _y) 
        {
            x = _x;
            y = _y;
        }
        public double R()
        {
            return Math.Sqrt(x*x + y*y);
        }
    }
}
