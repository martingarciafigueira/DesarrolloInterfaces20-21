using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[10];
            float[] sueldo = new float[10];
            int[] op = new int[10];
            int i;


            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}º persona", i + 1);
                Console.Write("Sueldo:");
                sueldo[i] = float.Parse(Console.ReadLine());
                Console.Write("Nombre:");
                nombre[i] = Console.ReadLine();
                Console.Write("1 = Femenino, 2 = Masculino:");
                op[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mujeres que ganan más de 1000€");
            for (i = 0; i < 10; i++)
            {
                if (op[i] == 1 && sueldo[i] > 1000)
                    Console.WriteLine("Nombre: {0}|Sexo: {1}|Sueldo: {2}", nombre[i], op[i], sueldo[i]);
            }
            Console.WriteLine("Hombres que ganan menos de 1200€");
            for (i = 0; i < 10; i++)
            {
                if (op[i] == 2 && sueldo[i] < 1200)
                {
                    Console.WriteLine("Nombre: {0}|Sexo: {1}|Sueldo: {2}", nombre[i], op[i], sueldo[i]);
                }
            }
            Console.Read();
        }
    }
}
