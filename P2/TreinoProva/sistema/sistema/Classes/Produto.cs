using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    abstract class Produto
    {
        public string Marca { get; private set; }
        public string Cor { get; private set; }
        public double Valor { get; private set; }

        public Produto(string marca, string cor, double valor)
        {
            Marca = marca;
            Cor = cor;
            Valor = valor;
        }
    }
}
