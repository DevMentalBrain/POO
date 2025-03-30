using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Area.Classes
{
    internal class CalculadoraGeometrica
    {
        public double CalcularAreaTriangulo(double segmentoRecebida, double alturaRecebida)
        {
            return segmentoRecebida * (alturaRecebida / 2);
        }

        public double CalcularAreaQuadrado(double segmentoRecebido, double alturaRecebida)
        {
            return segmentoRecebido * alturaRecebida;
        }

        public double CalcularAreaCirculo(double raioRecebido)
        {
            return Math.PI * (Math.Pow(raioRecebido, 2));
        }
    }
}
