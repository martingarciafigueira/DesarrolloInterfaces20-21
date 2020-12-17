using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Harry Potter", 12, "Rowling");
            Libro libro2 = new Libro("ESDLA", 20, "Tolkien");

            DVD dvd1 = new DVD("Titanic", 13, 180);
            DVD dvd2 = new DVD("Gladiator", 15, 120);

            //Publicacion publicacion1 = new Publicacion("Diario Marca", 1);

            Console.ReadKey();
        }
    }
}
