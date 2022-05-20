using System;
using System.Collections.Generic;
using System.Linq;

namespace InyeccionDeDependencias
{
    internal class Libreria
    {
        public Libreria()
        {
        }

        public List<Libro> Libros { get; set; } = new List<Libro>();

        internal void Imprimir( int libroId )
        {

            if( Libros.Any( libro => libro.LibroId == libroId) )
            {
                Libro libro = Libros.Single( libro => libro.LibroId == libroId );
            }
            

        }
    }
}