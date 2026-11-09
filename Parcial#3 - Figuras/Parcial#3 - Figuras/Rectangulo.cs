using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3___Figuras
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
