using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Poligon2026310a
{
    internal class Poligon
    {
        int broj_temena;
        Tacka[] temena;

        public Poligon(int n)
        {
            broj_temena = n;
            temena = new Tacka[n];
            for (int i = 0; i < n; i++)
            {
                temena[i] = new Tacka();
            }
        }

        public void Unos()
        {
            for (int i = 0; i < broj_temena; i++)
            {
                Console.WriteLine($"Uneti x i y koordinate od temena broj {i + 1}. U formatu: X Y");

                string line = Console.ReadLine();
                string[] left_right = line.Split(' ');
                double x = Convert.ToDouble(left_right[0]);
                double y = Convert.ToDouble(left_right[1]);
                temena[i].x = x;
                temena[i].y = y;
            }
        }

        public void Stampaj()
        {
            Console.WriteLine($"Poligon od {broj_temena} temena: ");
            int i = 1;
            foreach (Tacka tacka in temena)
            {
                Console.WriteLine($"A{i} ({tacka.x}, {tacka.y})");
                i++;
            }
        }

        public void Snimi()
        {
            StreamWriter izlaz = new StreamWriter("podaci.txt");
            izlaz.WriteLine(broj_temena);
            foreach (Tacka tacka in temena)
            {
                izlaz.WriteLine($"{tacka.x}");
                izlaz.WriteLine($"{tacka.y}");

            }

            izlaz.Close();

        }

        public static Poligon Ucitaj()
        {
            Poligon poligon = new Poligon(0);
            StreamReader ulaz = new StreamReader("podaci.txt");

            poligon.broj_temena = Convert.ToInt32(ulaz.ReadLine());
            poligon.temena = new Tacka[poligon.broj_temena];
            for (int i = 0; i < poligon.broj_temena; i++)
            {
                poligon.temena[i] = new Tacka(Convert.ToDouble(ulaz.ReadLine()), Convert.ToDouble(ulaz.ReadLine()));
            }
            ulaz.Close();
            return poligon;

        }

        public static Vektor[] VratiStranice(Poligon a)
        {
            Vektor[] stranice = new Vektor[a.broj_temena];

            for (int i = 0; i < a.broj_temena; i++)
            {
                int prvi = i;
                int drugi = (i + 1) % a.broj_temena;

                stranice[i] = new Vektor(a.temena[prvi], a.temena[drugi]);

            }
            return stranice;

        }

        public double Obim()
        {
            Vektor[] stranice = VratiStranice(this);
            double O = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                O += stranice[i].duzina();

            }
            return O;
        }
    }
}
