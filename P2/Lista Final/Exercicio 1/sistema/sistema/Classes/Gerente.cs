using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema.Interfaces;

namespace sistema.Classes
{
    internal class Gerente : Funcionario, IAumentarSalario
    {
        public double Bonus { get; private set; }
        public Gerente(string nome, int idade, double salarioBase, double bonus) : base(nome, idade, salarioBase)
        {
            Bonus = bonus;
        }

        public void SetBonus(double novoBonus)
        {
            Bonus = novoBonus;
        }

        public void AumentarSalario(double porcentagem)
        {
            SetSalario(SalarioBase * (1 + (porcentagem / 100)));
        }

        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }

    }
}
