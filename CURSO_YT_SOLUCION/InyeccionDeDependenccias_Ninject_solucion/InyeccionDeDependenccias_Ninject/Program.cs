using System;
using System.Reflection;


namespace InyeccionDeDependenccias_Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Ingresa un nombre");
            var name = Console.ReadLine();


            Console.WriteLine("Ingresa una habilidad");
            var skill = Console.ReadLine();

            var kernel = new StandardKernel();
            kernel.load( Assembly )

        }
    }

    public class PersonajeNew : IPersonaje
    {
        public string Nombre { get; set; }
        public string Habilidad { get; set; }

        public PersonajeNew( string nombre, string habilidad )
        {
            Nombre = nombre;
            Habilidad = habilidad;
        }

    }

}
