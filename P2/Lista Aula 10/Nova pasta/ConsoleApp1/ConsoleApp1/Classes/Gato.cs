using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome){}

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

        public void Cacar()
        {
            Console.WriteLine("Esta caçando");
        }
    }
}
