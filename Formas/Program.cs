using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear Diagrama");
            Diagrama diagrama1 = new Diagrama();
            diagrama1.rellenarLista();
            Console.WriteLine("Area total: " + diagrama1.calcularArea());
            Console.WriteLine("Perimetro total: " + diagrama1.calcularPerimetro());
        }
    }
}
