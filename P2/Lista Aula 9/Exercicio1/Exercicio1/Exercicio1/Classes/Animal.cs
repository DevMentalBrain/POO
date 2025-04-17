using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Classes
{
    internal class Animal
    {
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Animal(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal fez um som!");
        }
    }
}
