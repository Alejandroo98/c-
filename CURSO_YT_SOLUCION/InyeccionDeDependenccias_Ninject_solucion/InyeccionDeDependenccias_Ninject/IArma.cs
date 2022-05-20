

namespace InyeccionDeDependenccias_Ninject
{
    public interface IArma
    {
        public bool Disparar( IPersonaje personaje );
        public bool Golpear( IPersonaje personaje );
    }

    public interface IPersonaje
    {
        string Nombre { get; }
        string Habilidad { get; }
    }

}
