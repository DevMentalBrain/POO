using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class Quadrado : FiguraGeometrica
    {
        public double Lado { get; private set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }

    }
}
