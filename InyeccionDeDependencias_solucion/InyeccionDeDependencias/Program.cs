using System;

namespace InyeccionDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int libroId = 1;

            Libreria libreria = new Libreria();
            libreria.Libros.Add(new Libro() { LibroId = libroId, Titulo = "El secreto", Autor = "RHONDA BYRNE" });

            libreria.Imprimir(libroId);

        }

    }
}
