using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    class Cuenta
    {
        private string nombre;
        private string numCuenta;
        private double saldo;
        private double tipoInteres;

        public string Nombre { get => nombre; set => nombre = value; }
        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double TipoInteres { get => tipoInteres; set => tipoInteres = value; }
    }
}
