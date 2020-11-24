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

            //Declarando: variável N
            int n = int.Parse(Console.ReadLine());

            //Declarando:  matriz com os números inteiros
            int[,] mat = new int[n, n];

            //Usa a repetição para se estabelecer limite na matriz
            for (int i = 0; i < n; i++) 
            {

                //Utilizando split para o alinhamento na matriz
                string[] values = Console.ReadLine().Split();


                //Repetição: variável da coluna atribuindo 0 com um contador 
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Print dos valores
            Console.WriteLine("Diagonal Principal:");

            //Repetição que passa pela matriz e identifca os elementos
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(mat[i, i] + " ");

            }

            //Print vazio
            Console.WriteLine();

            //Variável de contador
            int count = 0;

            //Repetição: percorrer a Linha
            for (int i = 0; i < n; i++) 
            {

                //Repetição: percorrer a coluna 
                for (int j = 0; j < n; j++)
                {

                    //Condição: valores da matriz for menor que zero
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

        }
    }
}