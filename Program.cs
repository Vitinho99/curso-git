using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corse_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios serão registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>();
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Empregados #" + i + ":");

                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome # ");
                string nome = Console.ReadLine();

                Console.WriteLine("Salario # ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
                

            }
            Console.WriteLine("Digite o ID do funcionario que terá aumento salarial ");
            int searchId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Digite o percentual: ");
                double percentual = double.Parse(Console.ReadLine());
                emp.AumentoSalarial(percentual);
            }
            else
            {
                Console.WriteLine("Id não existe: ");
            }

            Console.WriteLine();


            Console.WriteLine("Lista Atualizada dos funionarios");
            foreach (Empregado obj in list)
            {
                Console.WriteLine(obj);
            }

            {
                Console.ReadKey();
            }

        }

    }

}

