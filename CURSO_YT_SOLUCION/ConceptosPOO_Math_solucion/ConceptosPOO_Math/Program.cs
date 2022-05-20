using System;

namespace ConceptosPOO_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Cuando creas un mensaje y priemero le pones la palbra TODO, visual studio lo detecta y podrias accder a el desde la opcion VER/LISTA DE TAREAS. El "TODO" es un estandar de mensaje para las tareas importantes que tenemos que realizar.
            realizarTarea();
        }

        static void realizarTarea()
        {

            Punto origen = new Punto();
            Punto destino = new Punto( 115, 120 );

            double distancia = origen.DistanciaHasta( destino );

            Console.WriteLine($"La distancia entre los dos puntos es { distancia }");
            //Clase que sigue -> N34
        }

    }
}
