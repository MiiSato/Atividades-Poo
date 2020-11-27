using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto Polimorfismo
{
    class ProdutoUsado : ProdutoComum
    {
        string date;

        public override void Information()
        {
            base.Information();
            Console.WriteLine("Fabricado (DD/MM/AA): ");
            date = Console.ReadLine();

        }
        public override void Print()
        {
            Console.WriteLine(nome + " (Usado) - " + price + " ( Fabricado: " + date + ") ");
        }

    }
}
