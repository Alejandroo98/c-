using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependenccias_Ninject
{
    class ArmaX : IArma
    {
        public bool Disparar(IPersonaje personaje)
        {
            Console.WriteLine( "{0} esta disparando", personaje.Nombre );
            return true;
        }

        public bool Golpear(IPersonaje personaje)
        {
            Console.WriteLine( "{0} esta disparando", personaje.Nombre );
            return true;
        }
    }

    class Escopeta: IArma
    {
        public bool Disparar(IPersonaje personaje)
        {
            Console.WriteLine("{0} esta disparando", personaje.Nombre);
            return true;
        }

        public bool Golpear(IPersonaje personaje)
        {
            Console.WriteLine("{0} esta disparando", personaje.Nombre);
            return true;
        }
    }

}
