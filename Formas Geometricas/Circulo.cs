using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas Geometricas
{
    //definição do Circulo
    class Circulo : Forma
    {
        public double Raio { get; set; }
   
        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
