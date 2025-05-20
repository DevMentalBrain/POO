using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema.Interfaces;

namespace sistema.Classes
{
    internal class Diretor : Funcionario, IAumentarSalario
    {
        public double ParticipacaoMensal { get; private set; }
        public Diretor(string nome, int idade, double salarioBase, double participacaoMensal) : base(nome, idade, salarioBase)
        {
            ParticipacaoMensal = participacaoMensal;
        }

        public void SetParticipacaoMensal(double participacaoMensal)
        {
            ParticipacaoMensal = participacaoMensal;
        }
        public void AumentarSalario(double porcentagem)
        {
            SetSalario(SalarioBase * (1 + (porcentagem / 100)));
        }
        public override double CalcularSalario()
        {
            return SalarioBase * (1 + ParticipacaoMensal/100);
        }
    }
}
