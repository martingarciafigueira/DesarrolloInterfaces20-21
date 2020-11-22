using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Coche
    {
        int anhoMatriculacion;
        int capacidad;
        int CV;
        string color;

        public Coche()
        {
        }

        public Coche(int anhoMatriculacion, int capacidad, int cV, string color)
        {
            this.anhoMatriculacion = anhoMatriculacion;
            this.capacidad = capacidad;
            CV = cV;
            this.color = color;
        }
    }
}
