using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Unesite temena");
            Console.WriteLine("x0=");
            */
            Tacka A = new Tacka(3,0);
            Tacka B = new Tacka(4,-2);
            Tacka C = new Tacka(5, 0);
            Tacka D = new Tacka(4, 2);
            Vektor AB = new Vektor(A, B);
            Vektor BC = new Vektor(B, C);
            Vektor CD = new Vektor(C, D);
            Vektor DA = new Vektor(D, A);
            Vektor AC = new Vektor(A, C);
            Vektor BD = new Vektor(B, D);
            double dAB = AB.duzina();
            double dBC = BC.duzina();
            double dCD = CD.duzina();
            double dDA = DA.duzina();
            double dBD = BD.duzina();
            double dAC = AC.duzina();
            if ((dAB == dBC) && (dBC == dCD) && (dCD == dDA))
            {
                if (dBD == dAC)
                {
                    Console.WriteLine("Kvadrat");
                }
                else
                {
                    Console.WriteLine("Romb");
                }
            }
            else
            {
                Console.WriteLine("Nije pravilan");
            }
        }
    }
}
