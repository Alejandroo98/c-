using System;

using System.Threading.Tasks;

namespace Inyeccion_dependenciasYT
{
    public class MediasDeSeda : IBebida
    {

       public void Preparar()
        {
            Console.WriteLine("Se hace una medias de seda");
        }

    }
}
