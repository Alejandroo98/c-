using EntidadesBiblioteca;
using OrdenarNumerosLibreria;
using System;

namespace InterfacesReview_clase_30_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidadNumeros = 6;

            int[] numerosDesordenados = new int[cantidadNumeros]; //A esto le llamamos vector
            numerosDesordenados[0] = 4054;
            numerosDesordenados[1] = 54;
            numerosDesordenados[2] = 87;
            numerosDesordenados[3] = -6;
            numerosDesordenados[4] = 994;
            numerosDesordenados[5] = 89;



            Administrador administrador = new Administrador();
            int[] numerosOrdenados = administrador.ordenarNumeros(numerosDesordenados);

            foreach (int numero in numerosOrdenados) Console.WriteLine(numero);

            var estudiantes = new Estudiante[cantidadNumeros];
            estudiantes[0] = new Estudiante { Nombre = "Jefferson", Nota = 9 };
            estudiantes[1] = new Estudiante { Nombre = "Alejandro", Nota = 8 };
            estudiantes[2] = new Estudiante { Nombre = "Pepe", Nota = 7 };
            estudiantes[3] = new Estudiante { Nombre = "Lala", Nota = 6 };
            estudiantes[4] = new Estudiante { Nombre = "Lele", Nota = 5 };
            estudiantes[5] = new Estudiante { Nombre = "Lili", Nota = 4 };

            var estudiantesPorNota = administrador.ordenerPorNota(estudiantes);

            foreach (var estudiante in estudiantesPorNota)
            {
                Console.WriteLine($"Nombre: { estudiante.Nombre }, Nota: { estudiante.Nota }");
            }


        }
    }

}
