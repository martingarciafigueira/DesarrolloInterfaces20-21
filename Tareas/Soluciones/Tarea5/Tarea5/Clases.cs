using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace DI_Tarea_5_NicolasEstevezPazos
{
    interface IParametrosVideClub
    {
        void EstablecerCambiosPelicula(Pelicula recibidaPelicula, int indice);
        VideoClub RecuperarVideoclub();
    }
    public enum Generos { Accion, Terror, Drama, Comica, Aventuras, Comedias, Dramaticas, Musicales, Ciencia_ficcion, Belicas};
    public enum Estados { Disponible = 0, Alquilada = 1, None = -1}
    public class Pelicula
    {
        private string titulo;
        private string codigo;
        private string director;
        private Actor actor;
        private Estados estado = Estados.None;
        private DateTime fechaDevolucion = new DateTime(1900,01,01);

        #region Constructores
        public Pelicula(){}
        public Pelicula(string titulo, string codigo, string director)
        {
            this.titulo = titulo;
            this.codigo = codigo;
            this.director = director;
        }
        #endregion
        #region Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Director { get => director; set => director = value; }
        public Actor Actor { get => actor; set => actor = value; }
        public Estados Estado { get => estado; set => estado = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        #endregion
        #region Funciones
        public override string ToString()
        {
            string pelicula = "Titulo: " + Titulo;
            pelicula += " | Codigo: " + Codigo;
            pelicula += " | Director: " + Director;
            if (actor != null)
            {
                pelicula += " | Actor: " + Actor.ToString();
            }
            if(estado != Estados.None)
            {
                pelicula += " | Estado: " + Estado;
            }
            if( fechaDevolucion != null)
            {
                pelicula += " | FechaDevolucion: " + FechaDevolucion.Date;
            }
            return pelicula;
        }
        public string[] ArrayData()
        {
            string pelicula = Titulo;
            pelicula += "|" + Codigo;
            pelicula += "|" + Director;
            if (actor != null)
            {
                pelicula += "|" + Actor.StringListView();
            }
            else
            {
                pelicula += "|-";
            }
            if (estado != Estados.None)
            {
                pelicula += "|" + Estado;
            }
            else
            {
                pelicula += "|-";
            }
            if (fechaDevolucion != null)
            {
                pelicula += "|" + FechaDevolucion.Date;
            }
            else
            {
                pelicula += "|-";
            }

            return pelicula.Split('|');
        }
        #endregion
    }
    public class Actor
    {
        private DateTime fechaNacimiento = new DateTime(1900, 01, 01);
        private short edad;
        private string nombre;
        private string nif; //8 digitos + Letra Mayuscula

        #region Constructores
        public Actor(DateTime fechaNacimiento, string nombre, string nif)
        {
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Nif = nif;

            short cumplidoAnhoActual = 0;
            //Si el mes es superior al mes del cumpleaños sumamos 1
            if (fechaNacimiento.Month > DateTime.Now.Month)
            {
                cumplidoAnhoActual = 1;
            }//Si el mes es igual al cumpleaños y el dia es igual o superior al actual sumamos 1
            else if (fechaNacimiento.Month == DateTime.Now.Month)
            {
                if (fechaNacimiento.Day >= DateTime.Now.Day)
                {
                    cumplidoAnhoActual = 1;
                }
            }
            Edad = (short)((DateTime.Now.Year - fechaNacimiento.Year) + cumplidoAnhoActual);
        }
        #endregion
        #region Propiedades
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nif { get => nif; set => nif = value; }
        #endregion
        #region Funciones
        public static bool ComprobarNIF(string nif)
        {
            return Regex.Match(nif, "[1-9]{8}[A-Z]{1}").Success;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + " NIF: " + Nif + " fecha de nacimiento :" + FechaNacimiento.Day + "/" + FechaNacimiento.Month + "/" + FechaNacimiento.Day;
        }
        public string StringListView()
        {
            return Nombre + ", " + Nif + ", " + FechaNacimiento.Day + "/" + FechaNacimiento.Month + "/" + FechaNacimiento.Day;
        }
        #endregion
    }
    public class VideoClub
    {
        private List<Pelicula> listaPeliculas;
        private List<Generos> listaGeneros;
        private string codigo; // 1 letra mayuscula + 3 digitos + 1 letra minuscula
        #region Constructores
        public VideoClub(string codigo)
        {
            this.listaPeliculas = new List<Pelicula> { };
            this.listaGeneros = new List<Generos> { };
            this.codigo = codigo;
        }
        #endregion
        #region Propiedades
        public List<Generos> ListaGeneros { get => listaGeneros; set => listaGeneros = value; }
        public List<Pelicula> ListaPeliculas { get => listaPeliculas; set => listaPeliculas = value; }
        public string Codigo { get => codigo;}
        #endregion
        #region Funciones
        public void AnhadirGenero(Generos generoNuevo)
        {
            listaGeneros.Add(generoNuevo);
        }
        public void AnhadirPelicula(Pelicula peliculaNueva)
        {
            listaPeliculas.Add(peliculaNueva);
        }
        public static bool ComprobarCodigo(string codigo)
        {
            return Regex.Match(codigo, "[A-Z]{1}[1-9]{3}[a-z]{1}").Success;
        }
        #endregion
    }
}
