using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Classes
{
    internal class Passaro : Animal
    {
        public Passaro(string nome, int idade) : base(nome, idade) { }

        public override void EmitirSom()
        {
            Console.WriteLine("Piu");
        }
    }
}
