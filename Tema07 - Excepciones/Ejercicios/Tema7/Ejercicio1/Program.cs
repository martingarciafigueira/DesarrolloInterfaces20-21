using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            int aux = int.Parse("Hola");


            try
            {
                Console.WriteLine("Mensaje mostrado por pantalla");
                Exception e = new Exception("Esto es un objeto Exception");
                throw e;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion capturada con mensaje: " + ex.Message);
            }
            Console.WriteLine("Programa terminado");
        }
    }
}
