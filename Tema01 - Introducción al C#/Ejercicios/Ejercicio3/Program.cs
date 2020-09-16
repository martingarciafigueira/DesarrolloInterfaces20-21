using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino las variables que voy a utilizar
            float numero;
            uint cont = 0, menor = 0, mayor = 0;

            //Creo un bucle que cuente 10 interacciones, también lo podría hacer con un bucle For
            while (cont < 10)
            {
                //Pido que me pasen un número por consola
                Console.Write("Ingrese número:");
                numero = float.Parse(Console.ReadLine()); //... cuidado aquí!

                //Compruebo si el número es mayor o menor que 0, e incremento el contador asociado
                if (numero > 0)
                {
                    mayor++;
                }
                if (numero < 0)
                {
                    menor++;
                }
                //Incremento el contador que va contando los números que voy introduciendo
                cont++;
            }
            Console.WriteLine("De 10 números son ...\nMenores a 0  = {0} y mayores a 0 = {1}", menor, mayor);
            Console.ReadLine();
        }
    }
}
