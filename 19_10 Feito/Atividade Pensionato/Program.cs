using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade de quartos utlizados
            Console.Write("Quantas pessoas irao alugar um quarto?");
            int pessoas = int.Parse(Console.ReadLine());
            Quarto[] quartos = new Quarto[10];

            for (int i = 0; i < pessoas; i++)
            {
                Console.WriteLine("\nHóspede #" + (i + 1) + ":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                quartos[numeroQuarto] = new Quarto { Nome = nome, Email = email };
            }

            //Quartos que estão ocupados
            Console.WriteLine("\nOcupados:");

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine((i) + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                }
            }
        }
    }
}
