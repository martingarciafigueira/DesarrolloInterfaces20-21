using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Contacto
    {
        private String nombre;
        private String apellidos;
        private String telefono;
        private String dni;
        private String sexo;
        private String estudios;
        private String vicios;

        //Constructor
        public Contacto(string nombre, string apellidos, string telefono, string dni, string sexo, string estudios, string vicios)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.dni = dni;
            this.sexo = sexo;
            this.estudios = estudios;
            this.vicios = vicios;
        }
        //Setters y Getters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Vicios { get => vicios; set => vicios = value; }

        //Comprueba si existe un dni en una lista
        public static bool ExisteDni(String strDni ,List<Contacto> lstContactos)
        {
            bool blnExiste = false;
            foreach( Contacto contacto in lstContactos){
                if (contacto.Dni == strDni )
                {
                    blnExiste = true;
                    break;
                }
            }
            return blnExiste;
        }

    }
}
