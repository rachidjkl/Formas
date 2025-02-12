using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rombo : Poligono
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Rombo(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override string ToString()
        {
            return $"";
        }

        public override double Area()
        {
            return (Diagonal1 * Diagonal2) / 2; ;
        }

        public override double Perimetro()
        {
            return 2 * Math.Sqrt(Math.Pow(Diagonal1, 2) + Math.Pow(Diagonal2, 2));
        }
    }
}
