using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8Electrodomesticos
{
    abstract class Electrodomestico
    {
        string consumoEnergetico;
        string anhoFabricacion;

        public Electrodomestico() { }

        public Electrodomestico(string consumoEnergetico, string anhoFabricacion)
        {
            this.ConsumoEnergetico = consumoEnergetico;
            this.AnhoFabricacion = anhoFabricacion;
        }

        public string ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }
        public string AnhoFabricacion { get => anhoFabricacion; set => anhoFabricacion = value; }
    }
}
