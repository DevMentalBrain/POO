﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Classes
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}
