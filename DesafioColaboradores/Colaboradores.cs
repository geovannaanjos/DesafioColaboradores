using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioColaboradores
{
    public class Colaboradores
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioAtual { get; set; }

        public Colaboradores(string nome, string cargo, double salarioatual)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioAtual = salarioatual;
        }
    }
}
