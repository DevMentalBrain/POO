using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Classes
{
    internal class AnimaisCadastrados
    {
        private List<Animal> animais;

        public AnimaisCadastrados(List<Animal> animais)
        {
            this.animais = new List<Animal>();
            this.animais = animais;
        }

        public List<Animal> ListarAnimaisCadastrados()
        {
            return animais;
        }
    }
}
