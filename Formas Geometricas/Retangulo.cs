using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas Geometricas
{
    //definição do Retangulo
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        
    public Retangulo(double largura, double altura, Color cor) : base(cor)
        { Largura = largura; Altura = altura; }

        public override double Area()
        {
            return Largura* Altura;
        }
    }
}
