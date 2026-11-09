using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3___Figuras
{
    public abstract class Figura
    {
        // Métodos abstractos que obligan a las clases hijas a implementarlos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
