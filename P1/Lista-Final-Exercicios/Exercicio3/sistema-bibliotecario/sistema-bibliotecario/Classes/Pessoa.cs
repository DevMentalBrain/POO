using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bibliotecario.Classes
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int qtdLivrosAlugado { get; set; }
        public Dictionary<int, LivroAlugado> livrosAlugados{ get; set; }

        public Pessoa(string nome) {
            this.nome = nome;
            qtdLivrosAlugado = 0;
        }

        public Dictionary<int, LivroAlugado> VerLivrosAlugados() {
            return livrosAlugados;
        }
    }
}
