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
            */
            /*
            Tacka A = new Tacka(-1, 1);
            Tacka B = new Tacka(-1, -1);
            Tacka C = new Tacka(1, -1);
            Tacka D = new Tacka(1, 1);
            Vektor AB = new Vektor(A, B);
            double Duzina_AB = AB.duzina();
            Vektor BC = new Vektor(B, C);
            double Duzina_BC = BC.duzina();
            Vektor CD = new Vektor(C, D);
            double Duzina_CD = CD.duzina();
            Vektor DA = new Vektor(D, A);
            double Duzina_DA = DA.duzina();
            Vektor AC = new Vektor(A, C);
            double Duzina_AC = AC.duzina();
            Vektor BD = new Vektor(B, D);
            double Duzina_BD = BD.duzina();
            if (Duzina_AC == Duzina_BD)
            {
                if (Duzina_AB == Duzina_BC && Duzina_BC==Duzina_CD && Duzina_CD == Duzina_DA && Duzina_DA == Duzina_AB)
                {
                    Console.WriteLine("Nije");
                }
                else Console.WriteLine("Jeste");
                /*
                if (Duzina_AB == Duzina_CD)
                {
                    if (Duzina_BC == Duzina_DA)
                    {
                        if (Duzina_AB != Duzina_BC)
                        {
                            Console.WriteLine("Jeste");
                            return;
                        }
                    }
                }
          
            
            }
        */
            Tacka A = new Tacka(-1, 1);
            Tacka B = new Tacka(-1, -1);
            Tacka C = new Tacka(2, -1);
            Tacka D = new Tacka(2, 1);
            Vektor AB = new Vektor(A, B);
            Vektor BC = new Vektor(B, C);
            Vektor CD = new Vektor(C, D);
            Vektor DA = new Vektor(D, A);
            Vektor AC = new Vektor(A, C);
            Vektor BD = new Vektor(B, D);

            double S_A = Vektor.skalarni(DA, AB);
            double S_B = Vektor.skalarni(AB, BC);
            double S_C = Vektor.skalarni(BC, CD);
            
            double S_T = Vektor.skalarni(AC, BD);
            if (S_A==0 && S_B==0 && S_C == 0)
            {
                if (S_T == 0)
                {
                    Console.WriteLine("Nije");
                    return;
                }
            }
            Console.WriteLine("Jeste");
        }
    }
}
