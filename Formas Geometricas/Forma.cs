using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas Geometricas
{
    abstract class Forma
    {
        public Color Color { get; set; }
        public Forma(Color color)

        {
            Color = color;
        }
        public abstract double Area();

    }
}
