using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Animal
    {
        public string Nome { get; private set; }

        public Animal(string nome)
        {
            this.Nome = nome;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emitiu um som!");
        }
    }
}
