using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Diagrama
    {
        public List<Forma> FigurasList { get; set; }
        
        public Diagrama() 
        { 
            FigurasList = new List<Forma>();
        }

        public void rellenarLista() 
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero1 = random.Next(1, 6);
                switch (numero1)
                {
                    case 1:
                        FigurasList.Add(new Circulo(5));
                        break;
                    case 2:
                        FigurasList.Add(new Triangulo(5, 4, 90));
                        break;
                    case 3:
                        FigurasList.Add(new Elipse(7, 3));
                        break;
                    case 4:
                        FigurasList.Add(new Cuadrado(10));
                        break;
                    case 5:
                        FigurasList.Add(new Rectangulo(5, 2));
                        break;
                    case 6:
                        FigurasList.Add(new Rombo(7, 3));
                        break;
                    default:
                        Console.WriteLine("Número fuera de rango.");
                        break;
                }
            }
        }

        public double calcularArea()
        {
            double areaTotal = 0;
            foreach (var item in FigurasList)
            {
                areaTotal += item.Area();
            }
            return areaTotal;
        }

        public double calcularPerimetro()
        {
            double perimetroTotal = 0;
            foreach (var item in FigurasList)
            {
                perimetroTotal += item.Perimetro();
            }
            return perimetroTotal;
        }



    }
}
