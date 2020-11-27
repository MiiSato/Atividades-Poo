using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto Polimorfismo
{
    class ProdutoComum
    {
        protected string nome;
        protected float price;

        public virtual void Information()
        {
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            price = float.Parse(Console.ReadLine());

        }
        public virtual void Print()
        {
            Console.WriteLine(nome + " - " + price);
            

        }


    }
}
