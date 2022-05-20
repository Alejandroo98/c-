using System;

namespace Inyeccion_dependenciasYT
{
    public class PiñaColada : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se prepara una piña colada");
        }
    }
}
