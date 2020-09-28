using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.Write("Dame un valor para ver qué impuesto ha puesto el gobierno: ");
            int.TryParse(Console.ReadLine(), out valor);

            if (valor >=0 && valor < 2000)
            {
                Console.WriteLine("Debe pagar un impuesto de un 0%");
            }
            else if (valor >= 2000 && valor < 3000)
            {
                Console.WriteLine("Debe pagar un impuesto de un 10%");
            }
            else if (valor >= 3000 && valor < 4000)
            {
                Console.WriteLine("Debe pagar un impuesto de un 25%");
            }
            else if (valor >= 4000)
            {
                Console.WriteLine("Debe pagar un impuesto de un 40%");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
