using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados do usuario que serão guardados nas variaveis privadas
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Instância de objeto pra classe Produto utilizando as variáveis privadas como parâmetros
            Produto p = new Produto(nome, preco, quantidade);

            //Informações do objeto, ToString
            Console.WriteLine("\nDados do produto \n" + p + "\n\n");

            //Adicionar produtos utilizado
            Console.Write("Valor em estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            //Informações do objeto, ToString
            Console.WriteLine($"\nDados do produto \n" + p + "\n\n");

            //Remove os produtos utilizado
            Console.Write("Valor a ser removido: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            //Informações do objeto, ToString
            Console.WriteLine($"\nDados atualizados \n" + p + "\n\n");
            Console.ReadKey();
        }
    }
}