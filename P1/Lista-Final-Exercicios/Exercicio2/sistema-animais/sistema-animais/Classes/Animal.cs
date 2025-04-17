using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistema_animais.Classes
{
    internal class Animal
    {
        public string nome { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string som { get; set; }
        public string locomocao  { get; set; }

        public string MoverAnimal()
        {
            string locomocao = this.locomocao;
            switch (locomocao)
            {
                case "Anda":
                    return $"{this.nome} andou!";
                case "Voa":
                    return $"{this.nome} voou!";
                case "Nada":
                    return $"{this.nome} nadou!";
            }
            return "ERRO!";
        }
    }
}
