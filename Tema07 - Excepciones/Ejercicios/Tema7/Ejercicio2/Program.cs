using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Generando número aleatorio");
                Random generador = new Random();
                int entero = (int)(generador.Next() * 1000);
                if (entero % 2 == 0)
                {
                    throw new Exception("Se generó un numero par");
                }
                else
                {
                    throw new Exception("Es impar");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
