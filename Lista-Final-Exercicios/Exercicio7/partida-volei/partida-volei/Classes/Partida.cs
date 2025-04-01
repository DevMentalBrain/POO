using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partida_volei.Classes
{
    internal class Partida
    {
        public Time timeCasa { get; private set; }
        public Time timeFora { get; private set; }
        public string placar { get; private set; }
        public int turno{ get; set; }

        public Partida(Time timeCasa, Time timeFora) 
        {
            this.timeCasa = timeCasa;
            this.timeFora = timeFora;
            this.placar = $"{timeCasa.pontos} x {timeFora.pontos}";
            this.turno = 0;
        }
        public void AlterarTimeCasa(Time timeCasa) 
        { 
            this.timeCasa = timeCasa;
        }
        public void AlterarTimeFora(Time timeFora)
        {
            this.timeFora = timeFora;
        }
        public void AlterarPlacar(string placar)
        {
            this.placar = placar;    
        }
        public void IniciarPartida()
        {
            turno++;
        }

    }
}
