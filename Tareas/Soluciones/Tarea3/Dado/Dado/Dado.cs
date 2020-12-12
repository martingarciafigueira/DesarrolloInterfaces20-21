using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        public static int intTiradaActual;
        public static int intSumaTiradas;
        public static List<int> tiradas = new List<int>();

        public static int tiradaFrecuente()
        {
            int tiradaFrecuente= 0;
            int contador = 0;

            for(int i = 0; i< tiradas.Count; i++)
            {
                int contadorNumActual = 0;
                for (int o = 0; o < tiradas.Count; o++)
                {
                    if(tiradas[i] == tiradas[o])
                    {
                        contadorNumActual += 1;
                    }
                }
                if (contadorNumActual > contador)
                {
                    tiradaFrecuente = tiradas[i];
                    contador = contadorNumActual;
                }
            }

            return tiradaFrecuente;
        }

    }
}
