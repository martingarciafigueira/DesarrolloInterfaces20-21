using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad4
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;
        private string estadoCivil = "SOLTERO";

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

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
            this.estadoCivil = "SOLTERO";
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
            Console.WriteLine(nombre + " " + apellidos + " " + edad + " " + dni + " " + estadoCivil);
        }


        /* OPCIÓN 1:
        public static void Main()
        {
            Persona nuevaPersona = new Persona();
            nuevaPersona.nombre = "Xabier";

            nuevaPersona.describirPersona();
            Console.ReadKey();
        }
        
        OPCIÓN 2:
        class Program
        {
            static void Main(string[] args)
            {
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = "Xabier";

                nuevaPersona.describirPersona();
                Console.ReadKey();
            }
        }
        */
    }
}
