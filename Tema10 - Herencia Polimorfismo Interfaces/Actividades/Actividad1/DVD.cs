using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1
{
    class DVD : Publicacion
    {
        int duracion;

        public DVD(string titulo, double precio, int duracion) : base(titulo, precio)
        {
            this.Duracion = duracion;
        }

        public int Duracion { get => duracion; set => duracion = value; }
    }
}
