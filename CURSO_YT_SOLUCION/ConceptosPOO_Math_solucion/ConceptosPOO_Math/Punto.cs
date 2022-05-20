using System;

namespace ConceptosPOO_Math
{
    internal class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public double DistanciaHasta( Punto punto )
        {

            int XDif = this.x - punto.x;
            int yDif = this.y - punto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(XDif, 2) + Math.Pow(yDif, 2));  //Math.Sqrt -> Raiz cuadrada; Math.Pow -> Elevar un numero a una potencia en este caso al cuadrado;

            return distanciaPuntos;

        }

    }
}