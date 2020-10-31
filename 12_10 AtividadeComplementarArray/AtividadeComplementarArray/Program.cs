using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComplementarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPessoas = 0;

            Console.Write("Entre com o numero de pessoas: ");

            numeroPessoas = int.Parse(Console.ReadLine());

            float[] alturas = new float[numeroPessoas];

            for(int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Entre com a altura da pessoa #" + (i + 1) + ": ");
                alturas[i] = float.Parse(Console.ReadLine());
            }

            Console.Write("A media das alturas inseridas é: " + alturas.Sum() / alturas.Length);

            Console.ReadKey();

        }
    }
}
