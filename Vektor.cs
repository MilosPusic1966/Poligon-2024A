using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024A
{
    internal class Vektor
    {
        Tacka pocetak, kraj;
        public Vektor() { }
        public Vektor(Tacka pocetak, Tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
        public Tacka centriraj()
        {
            return new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
        }
        public double duzina()
        {
            return centriraj().R();
        }
        public static double skalarni(Vektor a, Vektor b)
        {
            Tacka prva = a.centriraj();
            Tacka druga = b.centriraj();
            double SP = prva.x * druga.x + prva.y * druga.y;
            return SP;
        }
    }
}
