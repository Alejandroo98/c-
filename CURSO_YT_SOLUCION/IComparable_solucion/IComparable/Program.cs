using System;
using System.Collections.Generic;

namespace IComparable_nameSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>(){
                new Persona("Jonathan", "Alava"),
                new Persona("Fernando", "Alava"),
                new Persona("Edison", "Alava"),
                new Persona("Jefferson", "Alava"),
                new Persona("Alejandro", "Alava"),
                new Persona("Javier", "Alava"),
                new Persona("Javier", "Alava"),
                new Persona("Jossely", "Alava"),
                new Persona("Gloria", "Alava"),
                new Persona("Alicia", "Alava"),
                new Persona("Andrea", "Alava")
            };

            Console.WriteLine("===== LISTA DE NOMBRES DESORDEANDO ====== ");
            foreach (var personaIem in personas)
            {
                Console.WriteLine(personaIem);
            }

            personas.Sort();

            Console.WriteLine("===== LISTA DE NOMBRES ORDENADO ====== ");
            foreach (var personaIem in personas)
            {
                Console.WriteLine(personaIem);
            }


        }
    }

    public class Persona : IComparable, IEquatable<Persona>
    {

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }


        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int CompareTo(object obj)
        {
            int number = this.Nombre.CompareTo((obj as Persona).Nombre);
            return number;
        }

        public bool Equals(Persona other)
        {
            return (this.Nombre, this.Apellido) == (other.Nombre, other.Apellido);
        }

        public override string ToString()
        {
            return String.Format($"Nombre: { this.Nombre }, Apellido: { this.Apellido }");
        }

    }

}
