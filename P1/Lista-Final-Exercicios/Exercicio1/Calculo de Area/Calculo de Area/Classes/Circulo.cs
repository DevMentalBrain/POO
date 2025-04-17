using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area.Classes
{
    internal class Circulo
    {
        private double raio;

        public Circulo(double raioRecebido)
        {
            this.raio = raioRecebido;
        }

        public void SetRaio(double raioRecebido)
        {
            this.raio = raioRecebido;
        }

        public double GetRaio()
        {
            return this.raio;
        }

        public double CalcularArea(double raioRecebido)
        {
            return Math.PI * (Math.Pow(raioRecebido, 2));
        }
    }
}
