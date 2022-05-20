using System;


namespace Inyeccion_dependenciasYT
{
    public class Cantinero
    {
        //PiñaColada bebida; //Mal
        IBebida bebida;

        public Cantinero( IBebida bebida )
        {
            this.bebida = bebida;
        }

        public void Preparar()
        {
            this.bebida.Preparar();
        }
    }
}
