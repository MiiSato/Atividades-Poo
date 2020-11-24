using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TarefaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pede o numero de funcionarios registrados
            Console.Write("Quantos funcion�rios ser�o registrados? ");
            int N = int.Parse(Console.ReadLine());

            //lista
            List<Funcionario> lista = new List<Funcionario>();

            //Usa o For pra repetir o pedido dos dados dos funcionarios de acordo com o n�mero de funcion�rios pra registro
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nFuncion�rio #" + (i + 1) + ":");
                //Dados do ID
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                //Dados do Nome
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                //Dados do sal�rio
                Console.Write("Sal�rio: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Insert(i, new Funcionario(id, nome));
                lista[i].Salario = salario;
            }

            //Define pelo ID, o funcion�rio que ir� receber o aumento
            Console.Write("\nId do funcion�rio que receber� aumento: ");
            string idAumento = Console.ReadLine();


            List<Funcionario> lista2 = lista.FindAll(x => x.Id.ToString("000") == idAumento);



            //condi��es se existe ou n�o o n�mero indicado para o aumento no banco de registros


            if (lista2 == null)
            {
                Console.WriteLine("O funcion�rio de ID " + lista2[0].Id.ToString("000") + " n�o existe!");

                Console.ReadKey();
            }

            else
            {
                Console.Write("Porcentagem de aumento de sal�rio: ");
                lista2[0].AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("\nLista atualizada de funcion�rios da Bravo: ");
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();
        }
    }
}