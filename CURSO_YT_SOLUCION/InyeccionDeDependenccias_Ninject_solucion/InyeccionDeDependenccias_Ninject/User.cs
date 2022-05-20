using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependenccias_Ninject
{
    class User
    {

        public IArma Arma { get; set; }

        public User( IArma arma )
        {
            this.Arma = arma;
        }

        public string Jugar( PersonajeNew personaje )
        {
            Arma.Disparar( personaje );
            Arma.Disparar( personaje );

            return string.Format("El personaje se llama {0} y tiene la habilidad de {1}",
                personaje.Nombre,
                personaje.Habilidad
            );

        }

    }
}
