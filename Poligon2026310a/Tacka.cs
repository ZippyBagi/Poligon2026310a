using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon2026310a
{
    internal class Tacka
    {

        public double x, y;

        public Tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }   

        public Tacka() { x = 0; y = 0; }
    
        public double d()
        {
            double distance = Math.Sqrt(x*x + y*y);

            return distance;
        }

        public double ugao()
        {
            double ugao = Math.Atan2(y, x);
            double ugaoStepeni = ugao * 180 / Math.PI;
            return ugaoStepeni;
        }
    }
}
