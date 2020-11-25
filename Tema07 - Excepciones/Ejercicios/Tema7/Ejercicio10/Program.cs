using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int posicion;
            char caracter;

            Console.WriteLine("Introduzca una cadena:");
            cadena = Console.ReadLine();
            Console.WriteLine("Introduzca una posición:");
            int.TryParse(Console.ReadLine(), out posicion);

            caracter = contiene(cadena, posicion);

            Console.WriteLine("El carácter {0} está en la posición {1} de la cadena {2}", caracter, posicion, cadena);
            Console.ReadKey();
        }

        public static char contiene(string cadena, int posicion)
        {
            Char caracter;
            if (posicion >= 0 && posicion < cadena.Length)
            {
                caracter = cadena[posicion];
            }
            else
            {
                throw new Exception("La posición no está en la cadena");
            }
            return caracter;
        }
    }
}
