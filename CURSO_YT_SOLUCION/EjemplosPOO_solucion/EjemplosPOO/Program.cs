using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //Creacion de objeto tipo circulo, Variable/objeto de tipo circulo;
            miCirculo = new Circulo(); //Iniciacion de varible/objeto de tipo circulo. Instanciar una clase
            //Console.WriteLine( miCirculo.calcular(5) );
            //Console.WriteLine( miCirculo.calcular(1) );


            ConversorEuroDolar conversorEuroDolar = new ConversorEuroDolar();

            conversorEuroDolar.cambaiarValorEuro( 15.15 );
            Console.WriteLine( conversorEuroDolar.convierte(10) );
            

        }
    }


    class Circulo
    {

        const double pi = 3.1416; //Esto es una propiedad de la clase circulo. O campo de clase;
        public  double calcular( int radio ) //Metodo de clase. ¿Que puedes hacer los objetos de tipo cirulo?
        {

            return pi * (radio * radio);

        }

    }


    class ConversorEuroDolar
    {
        double euro = 1.253;

        public double convierte( double cantidad )
        {

            return cantidad * euro;


        }

        public void cambaiarValorEuro( double nuevoValor )
        {
            if (nuevoValor < euro) Console.WriteLine("Numero invalido");
            else euro = nuevoValor;
        }

    }



}
