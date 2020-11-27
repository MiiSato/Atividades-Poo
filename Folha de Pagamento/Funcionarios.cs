using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folha de Pagamento
{
    class Funcionarios
    {

        protected string nome;
        protected int horas;
        protected float vph;

        public virtual void Information()
        {
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Horas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora: ");
            vph = float.Parse(Console.ReadLine());

        }
        public virtual void Print()
        {
            Console.WriteLine(nome + " - R$ " + (vph*horas));


        }
    }
}
