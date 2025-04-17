using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area.Classes
{
    internal class Quadrado
    {
        private double baseForma;
        private double altura;

        public Quadrado(double baseRecebida, double alturaRecebida)
        {
            this.baseForma = baseRecebida;
            this.altura = altura;
        }

        public void SetBase(double baseRecebida)
        {
            this.baseForma = baseRecebida;
        }

        public double GetBase()
        {
            return this.baseForma;
        }

        public void SetAltura(double alturaRecebida)
        {
            this.altura = alturaRecebida;
        }

        public double GetAltura()
        {
            return this.altura;
        }

    }
}
