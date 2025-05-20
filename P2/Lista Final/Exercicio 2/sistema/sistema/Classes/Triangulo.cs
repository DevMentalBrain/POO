using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema.Interfaces;

namespace sistema.Classes
{
    internal class Triangulo : FiguraGeometrica, IDesenho
    {
        public double Lado1 { get; private set;}
        public double Lado2 { get; private set;}
        public double Lado3 { get; private set;}

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            return (Lado1 * Lado2) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
