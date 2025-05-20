using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class Eletronico : Produto
    {
        public bool Bivolt { get; private set; }
        public Eletronico(string marca, string cor, double valor, bool bivolt) : base(marca, cor, valor)
        {
            Bivolt = bivolt;
        }
    }
}
