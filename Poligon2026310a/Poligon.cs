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

        public bool prost()
        {

            Vektor[] stranice = VratiStranice(this);

            for (int i = 0; i < broj_temena - 1; i++)
            {
                for (int j = i + 1; j < broj_temena; j++)
                {
                    if (Tacka.jednake(temena[i], temena[j]))
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < stranice.Length - 2; i++)
            {
                for (int j = i + 2; j < stranice.Length; j++)
                {
                    if (i == 0 && j == stranice.Length - 1)
                    {
                        continue;
                    }

                    if (Vektor.daLiSeVektoriSeku(stranice[i], stranice[j]))
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        public bool Konveksan()
        {
            int plusevi = 0;

            for (int i = 0; i < broj_temena; i++)
            {
                Tacka prva = temena[i];
                Tacka druga = temena[(i + 1) % broj_temena];
                Tacka treca = temena[(i + 2) % broj_temena];

                Vektor prvi_vektor = new Vektor(prva, druga);
                Vektor drugi_vektor = new Vektor(druga, treca);

                if (Vektor.VektorskiProizvod(prvi_vektor, drugi_vektor) > 0) plusevi++;
            }
            if (plusevi == broj_temena | plusevi == 0)
            {
                return true;
            }
            return false;
        }

        public double Povrsina()
        {
            double P = 0;

            return P;
        }
    }
}
