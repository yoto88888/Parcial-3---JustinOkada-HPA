using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3___Figuras
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double @base, double altura, double lado1, double lado2, double lado3)
        {
            Base = @base;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
