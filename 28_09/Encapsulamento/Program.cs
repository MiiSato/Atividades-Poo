using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preço do produto: em reais: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade em estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());   
            Produto p = new Produto(nome, preco, quantidade); 
            
            Console.WriteLine("\nDados do produto \n" + p + "\n\n");          
            Console.Write("Digite o quantidade a ser adicionada ao estoque: ");

            p.AdicionarProdutos(int.Parse(Console.ReadLine()));          
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");
            Console.Write("Digite o quantidade a ser removida ao estoque: ");

            p.RemoverProdutos(int.Parse(Console.ReadLine()));         
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");
            Console.ReadKey();
        }
    }
}
