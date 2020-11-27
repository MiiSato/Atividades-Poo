using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha de Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            Funcionarios funcionario = new Funcionarios();
            int qnt;
            char terc;

            Console.WriteLine("Número de funcionários: ");
            qnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qnt; i++)
            {
                bool valido = false;
                while (!valido)
                {
                    Console.WriteLine("\n\n Tercerizado?(S/N): ");
                    terc = char.Parse(Console.ReadLine());
                    valido = true;
                    if (terc == 'S')
                    {
                        funcionario = new Tercerizados();
                    }
                    else if (terc == 'N')
                    {
                        funcionario = new Funcionarios();
                    }
                    else
                    {
                        valido = false;
                        Console.WriteLine("Comando inválido");
                    }
                }
                funcionario.Information();
                funcionarios.Add(funcionario);
               
            }

            Console.WriteLine("\nPagamentos: \n");
            foreach (Funcionarios f in funcionarios)
            {
                f.Print();

            }
            Console.ReadLine();

        }
    }
}
