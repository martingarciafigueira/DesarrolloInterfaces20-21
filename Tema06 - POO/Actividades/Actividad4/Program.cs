using System;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona nuevaPersona = new Persona();
            nuevaPersona.Nombre = "Xabier";

            Persona nuevaPersona2 = new Persona("Ignacio", "Rodriguez", 20, "123");
            nuevaPersona.Nombre = "Xabier";

            nuevaPersona.describirPersona();
            Console.ReadKey();
        }
    }
}
