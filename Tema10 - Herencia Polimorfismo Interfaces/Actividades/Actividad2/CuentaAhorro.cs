using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2
{
    class CuentaAhorro : Cuenta
    {
        double cuotaMantenimiento;

        public CuentaAhorro() : base() {}

        public CuentaAhorro(string nom, string cue, double sal, double tipo, double cuotaMantenimiento) : base(nom, cue, sal, tipo)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public void asignarCuotaMantenimiento(double cuota)
        {
            this.cuotaMantenimiento = cuota;
        }

        public double obtenerCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }

        public new void reintegro(double cantidad)
        {
            
        }
    }
}
