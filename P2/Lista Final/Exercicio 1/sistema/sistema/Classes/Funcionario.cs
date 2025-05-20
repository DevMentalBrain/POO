using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    abstract class Funcionario
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double SalarioBase { get; private set; }

        public Funcionario(string nome, int idade, double salarioBase)
        {
            Nome = nome;
            Idade = idade;
            SalarioBase = salarioBase;
        }

        public void SetSalario(double novoSalario)
        {
            SalarioBase = novoSalario;
        }

        public abstract double CalcularSalario();
    }
}
