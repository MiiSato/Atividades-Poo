using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TarefaBanco
{
    class Program
    {


        static void Main(string[] args)
        {

            //Pede os dados da conta
            Console.Write("Entre com o n�mero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("\nHaver� deposito inicial? (s/n): ");
            string decisao = Console.ReadLine();


            //deci��o de iniciar com dep�sito 
            if (decisao == "s")
            {
                Console.Write("\nEntre com o valor de dep�sito inicial: ");
                double valorIn = double.Parse(Console.ReadLine());

                Console.Write("\nDados da conta: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + valorIn);
                //entra com valor pra dep�sito
                Console.Write("\nEntre com um valor para dep�sito: ");
                int quantDep = int.Parse(Console.ReadLine());

                double d = quantDep + valorIn;
                double totalDep = d;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalDep);
                //entra com valor pra saque
                Console.Write("\nEntre com um valor para saque: ");
                int quantSaq = int.Parse(Console.ReadLine());

                double s = totalDep - quantSaq;
                double totalSaq = s;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalSaq);
                Console.ReadKey();
            }
            //deci��o de n�o iniciar com Deposito
            if (decisao == "n")
            {
                double T = 0;
                double total = T;

                Console.Write("\nDados da conta: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + total);
                //entra com valor pra dep�sito
                Console.Write("\nEntre com um valor para dep�sito: ");
                int quantDep = int.Parse(Console.ReadLine());

                double d = quantDep + total;
                double totalDep = d;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalDep);
                //entra com valor pra saque
                Console.Write("\nEntre com um valor para saque: ");
                int quantSaq = int.Parse(Console.ReadLine());

                double s = totalDep - quantSaq;
                double totalSaq = s;

                Console.Write("\nDados atualizados: Conta "
                    + numConta
                    + "\n Titular: " + nome
                    + "\n Saldo: " + totalSaq);
                Console.ReadKey();
            }

        }
    }
}