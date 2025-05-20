using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class Roupa : Produto
    {
        public string Tamanho { get; set; }
        public Roupa(string marca, string cor, double valor, string tamanho) : base(marca, cor, valor)
        {
            Tamanho = tamanho;
        }
    }
}
