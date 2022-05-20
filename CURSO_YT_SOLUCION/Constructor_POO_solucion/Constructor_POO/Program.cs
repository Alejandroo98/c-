using System;

namespace Constructor_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche cocheUno = new Coche("blanco"); //Aqui crea un objeto;
            Console.WriteLine( cocheUno.getRuedasColor() );
            

            Coche cocheDos = new Coche("rojo");
            Console.WriteLine(cocheDos.getRuedasColor());

        }
    }

    class Coche
    {

        public Coche()
        {
            ruedas = 4;

            puertas = 4;

            color = "negro";
        }

        public Coche( string nuevoColor )
        {
            color = nuevoColor;
        }

        private int ruedas;

        private int puertas;

        private string color;


        public string getRuedasColor()
        {
            return $"Tiene { ruedas } ruedas y su color es { color } y tiene { puertas } puertas";
        }

        public void numeroRuedas( int numeroRuedas )
        {
            ruedas = numeroRuedas;
        }


    }

}
