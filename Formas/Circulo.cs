using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Circulo:Elipse
    {
        public double RadioUnioco { get; set; }

        public Circulo(double radio1) : base(radio1, radio1)
        {
            RadioUnioco = radio1;
        }

        public override string ToString()
        {
            return $"";
        }

        public override double Perimetro()
        {
            return (2 * RadioUnioco * Math.PI);
        }
    }
}
