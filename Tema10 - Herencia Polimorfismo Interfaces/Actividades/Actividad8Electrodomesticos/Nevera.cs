using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad8Electrodomesticos
{
    class Nevera : Electrodomestico
    {
        int temperatura;

        public Nevera(string consumoEnergetico, string anhoFabricacion, int temperatura) : base(consumoEnergetico, anhoFabricacion)
        {
            this.temperatura = temperatura;
        }

        public override string ToString()
        {
            return "Nevera - Consumo energético: " + ConsumoEnergetico + " Año: " + AnhoFabricacion + " Temperatura: " + temperatura;
        }
    }
}
