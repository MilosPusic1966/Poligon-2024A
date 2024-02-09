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
        Vektor() { }
        Vektor(Tacka pocetak, Tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
        public Tacka centriraj()
        {
            return new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
        }
    }
}
