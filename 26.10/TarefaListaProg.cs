using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaLista
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Criando a lista de strings
            List<string> list = new List<string>();
            //Adicionando elementos na lista de strings
            list.Add("F�bio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");
            //Vai adiciona um elemento na posi��o sugerida
            list.Insert(2, "Lucas");
            //Realiza um loop de leitura dos elementos inseridos
            foreach (string obj in list)
            {
            Console.WriteLine(obj);
            }
            //Conta quantos elementos tem na minha lista
            Console.WriteLine("\n\nQntde elementos na Lista: " + list.Count);
            //Vai encontrar o primeiro elemento que inicia com a letra A, com uma fun��o lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro elemento que come�a com a letra A: " + s1);
            //Vai encontra o �ltimo elemento que inicia com a letra A, com uma fun��o lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro elemento que come�a com a letra A: " + s2);
            //Procura os elementos pela sua posi��o
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nPrimeira posi��o de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("\n�ltima posi��o de 'A': " + pos2);
            //Procurando todos os nomes com 5 caracteres
            Console.WriteLine("\n\n\nElementos com 5 caracteres: ");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach(string obj in list2)
            {
                //Removendo Andre da lista
                list.Remove("Andre");
                Console.WriteLine("================================\n\n");
                Console.WriteLine(obj);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nAndre foi removido.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove determinado elemento da lista com inicial W
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("\n\n+++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido o elemento que come�a com W.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove o nome da posi��o 3
            list.RemoveAt(3);
            Console.WriteLine("\n\n+++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido o elemento da posi��o 3.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remove os nomes da lista a partir da posi��o (1) e quantos elementos (2)
            list.RemoveRange(1, 2);
            Console.WriteLine("\n\n++++++++++++++++++++++++++++++\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\nFoi removido 2 elementos a partir da posi��o 1.\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

    }
}