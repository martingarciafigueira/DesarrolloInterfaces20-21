using System;
using System.Net.Http;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int calificacion1 = 39, calificacion2 = 62, notapromedio;

            notapromedio = (calificacion1 + calificacion2) / 2;

            Console.WriteLine("La nota final es: " + notapromedio); //La nota final es 50

        }
    }
}
