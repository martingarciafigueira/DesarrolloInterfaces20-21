using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo las variables y les asigno los valores
            int numBalones = 2;
            string nombreEquipo = "Montecastelo FC";
            bool isExpulsado = true;
            string fechaNacimiento = "21/09/2020";
            long numSeguridadSocial = 1234567878552;

            //Intento realizar algunas asignaciones
            numBalones = nombreEquipo;
            numBalones = isExpulsado;
            fechaNacimiento = numSeguridadSocial;
            numBalones = numSeguridadSocial;
            numSeguridadSocial = numBalones;
        }
    }
}
