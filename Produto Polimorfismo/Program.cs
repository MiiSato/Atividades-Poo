using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto_Comum> produtos = new List<Produto_Comum>();
            Produto_Comum produto_comum = new Produto_Comum();
            string tipo;
            int qnt;


            Console.WriteLine("Número de produtos: ");
            qnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qnt; i++)
            {
                bool valido = false;
                while (!valido)
                {

                    Console.WriteLine("\n\n Qual tipo do produdo?(C/I/U): ");
                    tipo = Console.ReadLine();
                    tipo = tipo.ToUpper();

                    valido = true;

                    if (tipo == "C")
                    {
                        produto_comum = new Produto_Comum();
                    }
                    else if (tipo == "I")
                    {
                        produto_comum = new Produto_Importado();
                    }
                    else if (tipo == "U")
                    {
                        produto_comum = new Produto_Usado();
                    }
                    else
                    {
                        valido = false;
                        Console.WriteLine("Comando inválido");
                    }
                }

                produto_comum.Information();
                produtos.Add(produto_comum);

            }

            Console.WriteLine("\nEtiquetas: \n");
            foreach (Produto_Comum p in produtos)
            {
                p.Print();
                
            }
            Console.ReadLine();
        }
    }
}
