using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio2
{
    public class Persona
    {
        string _nombrePersona;
        int _edadPersona;
        string _dniPersona;
        string _generoPersona;

        public string NombrePersona
        {
            get { return _nombrePersona; }
            set { _nombrePersona = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona martin = new Persona();
            //No permite acceder debido a su nivel de protección
            Console.WriteLine(martin._nombrePersona);
            //Podríamos acceder si cambiamos su nivel de proteccion a public (mala práctica) o si creamos un método Getter
        }
    }
}
