using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Cachorro : Animal
    {
        public string Raca { get; private set; }

        public Cachorro(string nome, string raca) : base(nome){
            this.Raca = raca;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("AuAu");
        }
    }
}
