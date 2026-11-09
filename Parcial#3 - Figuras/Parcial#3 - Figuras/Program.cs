using System.Drawing;

namespace Parcial_3___Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración del arreglo unidimensional de tipo padre (Figura[])
            Figura[] figuras = new Figura[3];

            // Almacenando instancias de las clases derivadas
            figuras[0] = new Rectangulo(5.0, 10.0);
            figuras[1] = new Cuadrado(4.0);
            figuras[2] = new Triangulo(6.0, 4.0, 5.0, 5.0, 6.0);

            // Recorrido polimórfico
            foreach (Figura figura in figuras)
            {
                Console.WriteLine($"Clase: {figura.GetType().Name}");
                Console.WriteLine($"Área: {figura.CalcularArea()}");
                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
