using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto Polimorfismo
{
    class ProdutoImportado : ProdutoComum
    {
        float taxa;

        public override void Information()
        {
            base.Information();
            Console.WriteLine("Taxa: ");
            taxa = float.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine(nome + " - " + price + " ( Taxa: " + taxa + ") " );
            
        }
    }
}
