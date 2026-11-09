using System;
// PASO 2: Importar la librería instalada vía NuGet
using Newtonsoft.Json;

namespace Parcial_2___JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PASO 3: Crear objeto anónimo con los datos de la persona
            var persona = new
            {
                Nombre = "Cristell",
                Edad = 20,
                Carrera = "Ingeniería en Sistemas"
            };

            // PASO 4: Convertir el objeto C# a cadena en formato JSON
            string json = JsonConvert.SerializeObject(persona);

            // Mostrar la cadena JSON resultante en consola
            Console.WriteLine(json);

            // Detiene la consola para poder ver el resultado en Visual Studio
            Console.ReadLine();
        }
    }
}
