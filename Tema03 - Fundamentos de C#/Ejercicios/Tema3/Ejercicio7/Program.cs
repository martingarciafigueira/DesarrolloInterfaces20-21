using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorhr, hrstrab, antigue;
            string nombre;

            Console.Write("Nombre:");
            nombre = Console.ReadLine();

            Console.Write("Valor hora:");
            valorhr = float.Parse(Console.ReadLine());

            Console.Write("Antiguedad:");
            antigue = float.Parse(Console.ReadLine());

            Console.Write("Horas trabajadas:");
            hrstrab = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Antiguedad: {0}", antigue);
            Console.WriteLine("Valor hora: {0}", valorhr);
            Console.WriteLine("Total a cobrar: {0}", valorhr * hrstrab + antigue * 30);
            Console.WriteLine("Total del descuento: {0}", (valorhr * hrstrab + antigue * 30) * 0.13);
            Console.WriteLine("Total con descuento: {0}", ((valorhr * hrstrab + antigue * 30) - (valorhr * hrstrab + antigue * 30) * 0.13));
            Console.Read();
        }
    }
}
