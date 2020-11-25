using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua;
            do
            {
                try
                {
                    continua = false;
                    Console.Write("Ingrese un valor:");
                    string linea = Console.ReadLine();
                    var num = int.Parse(linea);
                    var cuadrado = num * num;
                    Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero.");
                    continua = true;
                }
            } while (continua);
            Console.ReadKey();
        }
    }
}
