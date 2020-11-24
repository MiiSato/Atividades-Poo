using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando: vari�vel N
            int n = int.Parse(Console.ReadLine());

            //Declarando:  matriz com os n�meros inteiros
            int[,] mat = new int[n, n];

            //Usa a repeti��o para se estabelecer limite na matriz
            for (int i = 0; i < n; i++) 
            {

                //Utilizando split para o alinhamento na matriz
                string[] values = Console.ReadLine().Split();


                //Repeti��o: vari�vel da coluna atribuindo 0 com um contador 
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Print dos valores
            Console.WriteLine("Diagonal Principal:");

            //Repeti��o que passa pela matriz e identifca os elementos
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(mat[i, i] + " ");

            }

            //Print vazio
            Console.WriteLine();

            //Vari�vel de contador
            int count = 0;

            //Repeti��o: percorrer a Linha
            for (int i = 0; i < n; i++) 
            {

                //Repeti��o: percorrer a coluna 
                for (int j = 0; j < n; j++)
                {

                    //Condi��o: valores da matriz for menor que zero
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

        }
    }
}