using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
namespace Clase_inyeccionDeDependenciad_01_07_2021
{
    internal class Libreria
    {
        public Libreria()
        {
        }

        public Collection<Libro> Libros { get; set; } = new Collection<Libro>();
        public string Ruta { get; set; } = "C:\Users\USER\Desktop\C#\Clase_inyeccionDeDependenciad_01_07_2021";


        internal void Imprimir( int libroId )
        {
            if (this.Libros.Any(actual => actual.LibroId == libroId))
            {
                 var libro = Libros.Single(actual => actual.LibroId == libroId);
                FileStream fileStream = File.Create($"{ Ruta }");

                var contenido = $"Id: { libro.LibroId }\n Titulo: { libro.Author }";

                byte[] buffer = contenido.ToArray

                fileStream.Write( contenido );


            }   
            
        }

    }
}