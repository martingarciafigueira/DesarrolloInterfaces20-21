using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1
{
    class Publicacion
    {
        string titulo;
        double precio;

        public Publicacion(string titulo, double precio)
        {
            this.Titulo = titulo;
            this.Precio = precio;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
