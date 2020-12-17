using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Actividad8Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        int carga;

        public Lavadora(string consumoEnergetico, string anhoFabricacion, int carga) : base(consumoEnergetico, anhoFabricacion)
        {
            this.carga = carga;
        }

        public override string ToString()
        {
            return "Lavadora - Consumo energético: " + ConsumoEnergetico + " Año: " + AnhoFabricacion + " Carga: " + carga;
        }
    }
}
