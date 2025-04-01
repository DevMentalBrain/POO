using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partida_volei.Classes
{
    internal class Time
    {
        public string nome { get; private set; }
        public int pontos { get; private set; }
        public bool vezDoTime { get; set; }

        public Dictionary<int, Jogador> listaDeJogadores = new Dictionary<int, Jogador>();

        public Time(string nome, Dictionary<int, Jogador> listaDeJogadores) {
            this.nome = nome;
            this.listaDeJogadores = listaDeJogadores;
            this.pontos = 0;
            this.vezDoTime = false;
        }

        public void SetNome(string nome) 
        {
            this.nome = nome;
        }
        public void AlterarPontos(int pontos)
        {
            this.pontos = pontos;
        }
        public void AdicionarJogador(Jogador jogadorRecebido) 
        {
            
        }
        public void AlterarVez(bool vezDoTime)
        {
            this.vezDoTime |= vezDoTime;
        }
        public bool VerificarJogador(string jogadorRecebido)
        {
            for(int i = 0;i < listaDeJogadores.Count; i++)
            {
                if(listaDeJogadores[i].nome == jogadorRecebido)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
