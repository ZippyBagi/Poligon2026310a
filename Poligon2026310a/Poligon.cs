using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i=0;i<n; i++)
            {
                temena[i] = new Tacka();
            }
        }

        public void Unos()
        {
            for(int i = 0; i < broj_temena; i++)
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
            Console.WriteLine("Koordinate temena su: ");
            foreach(Tacka tacka in temena)
            {
                Console.WriteLine($"{tacka.x} {tacka.y}");
            }
        }
    
    }
}
