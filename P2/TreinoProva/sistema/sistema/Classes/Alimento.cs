using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class Alimento : Produto
    {
        public DateTime DataVencimento { get; private set; }
        public Alimento(string marca, string cor, double valor, DateTime dataVencimento) : base(marca, cor, valor)
        {
            DataVencimento = dataVencimento;
        }
    }
}
