using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partida_volei.Classes
{
    internal class Jogador
    {
        public string nome { get; private set; }
        public int numeroDaCamisa { get; private set; }
        public double altura { get; private set; }

        public Jogador(string nome, int numeroDaCamisa, double altura) { 
            this.nome = nome;
            this.numeroDaCamisa = numeroDaCamisa;
            this.altura = altura;
        }

        public void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public void SetNumeroDaCamisa(int numeroDaCamisa)
        {
            this.numeroDaCamisa = numeroDaCamisa;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public void Sacar()
        {

        }

        public void Levantar()
        {

        }

        public void Atacar()
        {

        }
    }
}
