using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corse_Lista
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public  double Salario { get; set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalarial(double percentual)
        {
            Salario += Salario * percentual / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2");
        }


    }
}
