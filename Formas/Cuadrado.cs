using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Cuadrado : Rectangulo
    {
        public double LadoUnico { get; set; }
        public Cuadrado(double lado1) : base(lado1, lado1)
        {
            LadoUnico = lado1;
        }
    }
}
