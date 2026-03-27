using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026310a
{
    internal class Vektor
    {
        public Tacka pocetak;
        public Tacka kraj;

        public Vektor(Tacka pocetak, Tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
    
        public Vektor(Tacka A)
        {
            pocetak = new Tacka();
            kraj = A;
        }

        public Tacka Centriraj()
        {
            Tacka centar = new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);

            return centar;
        }

        public static double SkalarniProizbod(Vektor prvi, Vektor drugi)
        {
            Tacka a = prvi.Centriraj();
            Tacka b = drugi.Centriraj();

            return a.x * b.x + a.y * b.y;
        }
        
        public static double VektorskiProizvod(Vektor prvi, Vektor drugi)
        {
            Tacka a = prvi.Centriraj();
            Tacka b = drugi.Centriraj();

            return a.x * b.y - a.y * b.x;
        }

        public double duzina()
        {
            Tacka centar = Centriraj();
            return centar.d();
        }

        public static bool daLiSeVektoriSeku(Vektor a, Vektor b)
        {

            int a_b = Ravna.SaIsteStrane(a, b.pocetak, b.kraj);
            int b_a = Ravna.SaIsteStrane(b, a.pocetak, b.kraj);

            return ((a_b * b_a) != 0 );
        }
    }

}
