using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;
        private string estadoCivil;

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.edad = 0;
            this.dni = "";
            this.estadoCivil = "";
        }

        public Persona(string nombre, string apellidos, int edad, string dni, string estadoCivil)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
            this.estadoCivil = estadoCivil;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        public bool EsJubilado()
        {
            if (this.edad >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void describirPersona()
        {
            MessageBox.Show(nombre + " " + apellidos + " " + edad + " " + dni + " " + estadoCivil);
        }

    }
}
