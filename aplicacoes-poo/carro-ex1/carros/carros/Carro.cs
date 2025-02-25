using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros
{
    public class Carro
    {
        public string nome = "";
        public string cor = "";

        public void PintarCarro(string corNova)
        {
            cor = corNova;
        }
    }
}
