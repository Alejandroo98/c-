using System;
//using Interface;
using Ninject.Modules;
//usgin Arma1;

namespace InyeccionDeDependenccias_Ninject
{
    public class InyeccionDependencia : NinjectModule

    {
        public override void Load()
        {
            Bind<Iarma>().To<ArmaX>();
        }
    }
}
