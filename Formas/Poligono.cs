using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public abstract class Poligono : Forma
    {
        public int NumLados {  get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
