using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa los números

            int numero, total1= 0, total2=0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Inserta un número: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero > 0)
                {
                    total1 += numero;
                }
                else
                {
                    total2 += numero;
                }
            }

            Console.WriteLine("La suma de los positivos da: " + total1);
            Console.WriteLine("La suma de los negativos da: " + total2);

        }
    }
}
