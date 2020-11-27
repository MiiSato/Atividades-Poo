using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha de Pagamento
{
    class Tercerizados : Funcionarios
    {
        int add;

        public override void Information()
        {
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Horas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Adicional: ");
            add = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora: ");
            vph = float.Parse(Console.ReadLine());

            
        }

        public override void Print()
        {
            Console.WriteLine(nome + " - R$ " + (vph * horas + (add *1.1f)));
        }
    }
}
