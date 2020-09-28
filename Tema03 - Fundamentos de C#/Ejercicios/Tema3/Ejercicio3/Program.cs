using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, auxnumero;

            Console.Write("Dame el primer número, lo guardo en la variable numero1: ");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.Write("Dame el segundo número, lo guardo en la variable numero2: ");
            int.TryParse(Console.ReadLine(), out numero2);

            Console.WriteLine("La variable numero1 es: " + numero1 + " y la variable numero2 es: " + numero2);

            auxnumero = numero1;
            numero1 = numero2;
            numero2 = auxnumero;

            Console.Write("Si las intercambio, quedaría así: ");
            Console.Write("La variable numero1 es: " + numero1 + " y la variable numero2 es:" + numero2);
        }
    }
}
