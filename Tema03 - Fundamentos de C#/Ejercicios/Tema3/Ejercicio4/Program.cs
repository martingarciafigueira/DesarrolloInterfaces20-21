using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPesos, peso, contadorPersonas=0;

            Console.Write("¿Cuántos pesos vas a introducir?: ");
            int.TryParse(Console.ReadLine(), out numeroPesos);

            for (int i = 0; i < numeroPesos; i++)
            {
                Console.Write("Introduce un peso: ");
                int.TryParse(Console.ReadLine(), out peso);
                if (peso >=70 && peso <=90)
                {
                    contadorPersonas++;
                }
            }

            Console.WriteLine("Has introducido {0} personas entre 70 y 90 kilos", contadorPersonas);

        }
    }
}
