using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioColaboradores
{
    public class ColaboradoresAntigos : Colaboradores
    {
        public ColaboradoresAntigos(string nome, string cargo, double salarioatual) : base(nome, cargo, salarioatual)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioAtual = salarioatual;
        }

        public void NomeFuncionario()
        {
            Console.WriteLine($"Funcionário {Nome} - Cargo: {Cargo} e com o salário {SalarioAtual.ToString("C")}");
        }

    }
}
