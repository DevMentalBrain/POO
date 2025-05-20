using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class FuncionarioRegular : Funcionario
    {
        public FuncionarioRegular(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase){}

        public override double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
