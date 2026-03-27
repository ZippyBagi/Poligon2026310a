using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026310a
{
    internal class Ravna
    {
        public static int SaIsteStrane(Vektor AB, Tacka C, Tacka D)
        {

            Vektor AC = new Vektor(AB.pocetak, C);
            Vektor AD = new Vektor(AB.pocetak, D);


            double levi = Vektor.VektorskiProizvod(AB, AC);

            double desni = Vektor.VektorskiProizvod(AB, AD);

            if(levi == 0 || desni == 0)
            {
                return 1; //kolinearne
            }

            if((levi  > 0 && desni > 0) || (levi < 0 && desni < 0))
            {
                return 0; // sa iste strane
            }

            return -1; // sa razlicitih strana
        }


    }
}
