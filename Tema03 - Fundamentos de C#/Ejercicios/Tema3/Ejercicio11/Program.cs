using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, i = 0, mayordia = 0, menordia = 0, x = 30;
            int[] dia = new int[31];
            float menor = 0, mayor = 0, promedio = 0, contagua = 0;
            float[] agua = new float[x + 1];


            do
            {
                Console.Write("Ingrese dia:");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese agua caida:");
                agua[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    flag = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }
                }

                contagua += agua[i];

                if (i == 29)
                {
                    Console.Write("El mes tiene 31 dias s/n ?");
                    if (Console.ReadLine() == "s")
                        x = x + 1;
                }
                i++;
            } while (i < x);

            promedio = contagua / i;

            if (menor == mayor)
            {
                Console.Write("\nNo hubo mayor y menor dia de agua caida, fue igual para todos los dias {0}", menor);
            }
            else
            {
                Console.WriteLine("\nLa mayor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", mayor);
                for (i = 0; i < x; i++)
                    if (agua[i] == mayor)
                        Console.Write("\nDia {0}", dia[i]);

                Console.WriteLine("\n\nLa menor cantidad de agua caida fue de {0} milímetros el/los dia/s ...", menor);
                for (i = 0; i < x; i++)
                    if (agua[i] == menor)
                        Console.Write("\nDia {0}", dia[i]);
            }
            Console.WriteLine("\n\nEl promedio de agua caida en {0} dias es {1}", x, promedio);
            Console.Read();
        }
    }
}
