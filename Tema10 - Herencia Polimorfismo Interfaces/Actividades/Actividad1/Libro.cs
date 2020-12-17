using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1
{
    class Libro : Publicacion
    {
        string autor;

        public Libro(string titulo, double precio, string autor) : base(titulo, precio)
        {
            this.Autor = autor;
        }
        public string Autor { get => autor; set => autor = value; }
    }
}