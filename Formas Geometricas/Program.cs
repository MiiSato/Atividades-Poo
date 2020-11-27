using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas_FormasGeo;

namespace Formas Geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de uma lista para formas e pedindo o número de formas
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Numero de formas: ");
            int n = int.Parse(Console.ReadLine());

            //comando For: repetição das perguntas de acordo com o número de formas que o usuário solicitara
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Circulo(R / C) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto / Azul / Vermelho): ");
                Enum.TryParse<Color>(Console.ReadLine() ,out Color cor);

                //se for retangulo (R)
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                //Else: obtem a resposta contraria
                else
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
                
            }
            //Valores Totais
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
