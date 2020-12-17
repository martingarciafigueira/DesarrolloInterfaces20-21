using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad8Electrodomesticos
{
    class Television : Electrodomestico
    {
        int resolucion;

        public Television(string consumoEnergetico, string anhoFabricacion, int resolucion) : base(consumoEnergetico, anhoFabricacion)
        {
            this.resolucion = resolucion;
        }

        public override string ToString()
        {
            return "Televisión - Consumo energético: " + ConsumoEnergetico + " Año: " + AnhoFabricacion + " Resolución: " + resolucion;
        }
    }
}
