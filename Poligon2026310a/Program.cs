using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026310a
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            //Dusan Kovacevic
            /* Tacka a = new Tacka(-1, -1);

            Console.WriteLine(a.ugao());

            Console.WriteLine(a.d());

            Tacka A = new Tacka(3, 1);
            Tacka B = new Tacka(-1, 3);
            Tacka C = new Tacka(3, 3);

            Vektor OA = new Vektor(A);
            Vektor AC = new Vektor(A, C);
            Vektor OB = new Vektor(B);

            Console.WriteLine(Vektor.SkalarniProizbod(OA, OB));

            Console.WriteLine(Vektor.VektorskiProizvod(OA, AC));
            */

            Tacka A = new Tacka(1,2);
            Tacka B = new Tacka(3,2);
            Tacka C = new Tacka(2,3);
            Tacka D = new Tacka(2,2);

            Vektor AB = new Vektor(A, B);

            Console.WriteLine(Ravna.SaIsteStrane(AB, C, D));

            /*
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon prvi = new Poligon(n);
            prvi.Unos();
            Console.WriteLine();
            prvi.Stampaj();

            prvi.Snimi();
            */

            Poligon drugi = Poligon.Ucitaj();
            drugi.Stampaj();

        }
    
    }
}
