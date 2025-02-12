using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Elipse:Forma
    {
        public double Radio1 { get; set; }
        public double Radio2 { get; set; }

        public Elipse(double radio1, double radio2)
        {
            this.Radio1 = radio1;
            this.Radio2 = radio1;
        }

        public override string ToString()
        {
            return $"";
        }

        public override double Area()
        {
            return (Radio1 * Radio2 * Math.PI);
        }

        public override double Perimetro()
        {
            return (Radio1 * Radio2 * Math.PI);
        }
    }
}
