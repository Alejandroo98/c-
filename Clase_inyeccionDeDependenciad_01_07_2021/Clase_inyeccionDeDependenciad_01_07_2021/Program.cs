using System;

namespace Clase_inyeccionDeDependenciad_01_07_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Libreria libreria = new Libreria();
            var Libro = new Libro { LibroId = 1, Titulo = "El valor domado", Author = "Esther Vailar" };
            libreria.Libros.Add( Libro );

            libreria.Imprimir( Libro.LibroId );
        }
    }

    class Libro
    {
        public string Titulo { get; set; }
        public string Author { get; set; }
        public int LibroId { get; set; }
    }
}
