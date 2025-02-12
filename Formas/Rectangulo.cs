using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rectangulo:Poligono
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Rectangulo(double lado1, double lado2) 
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        public override string ToString()
        {
            return $"";
        }

        public override double Area()
        {
            return (Lado1 * Lado2);
        }

        public override double Perimetro()
        {
            return (Lado1*2 + Lado2*2);
        }
    }
}
