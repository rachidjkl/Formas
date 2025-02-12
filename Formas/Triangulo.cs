using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Triangulo:Poligono
    {
        public double Basee { get; set; }
        public double Altura { get; set; }
        public double Angulo {  get; set; }

        public Triangulo(double Basee, double Altura, double Angulo)
        {
            this.Basee = Basee;
            this.Altura = Altura;
            this.Angulo = Angulo;
        }

        public override string ToString()
        {
            return $"";
        }

        public override double Area()
        {
            return (Basee * Altura)/2;
        }

        public override double Perimetro()
        {
            double b = Math.Sqrt(Math.Pow(Basee, 2) + Math.Pow(Altura, 2));

            double c = Altura / Math.Sin(Angulo * Math.PI / 180.0);

            return Basee + b + c;
        }
    }
}
