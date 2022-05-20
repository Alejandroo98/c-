using System;

namespace INTERFACES
{
    class Program
    {

    /* EN RESUMEN LO QUE HAGO AQUI ES MOSTRARTE COMO TIENES QUE HACER EN CASO LOS METODOS DE DOS DIFERENTES INTERFACES SON IGUALES, EN ESTA CLASE DONDE HEREDAMOS DE ESTAS DOS INTERFACES CON METODOS IGUALES ES HACER REFERENCIA PRIMERO AL LA INTERFA Y LUEGO SI AL METODO, AL MOMENTO DE INSTANCIAR PARA LLAMAR A ESTE METODO EN PARTICULAR, RECUERDA
       QUE HAY DOS METODOS IGUALES DENTRO DE ESTA CLASE ASI QUE LO QUE TIENES QUE HACER ESTA EN LAS LINEAS DE MAS ABAJO, INSTANCIAAR LUEGO A ESE OJETO LO PONES QUE SEA DE TIPO DE LA INSTANCIA DEL METODO QUE QUIERES LLAMAR. ESTO DE LOS METODOS IGUALES OCURRE POCAS VESCES ASI QUE DONT WORRRY, BETTER BE HAPPY
     */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animales animales = new Animales();

            ISalta animalSalta = animales;
            Console.WriteLine(animalSalta.score());

            ICorre animalCorre = animales;
            Console.WriteLine(animalCorre.score());


        }

        interface ICorre
        {
            public int Velocidad { get; set; }

            int score();

        }


        interface ISalta
        {
            public int Altura { get; set; }

            int score();

        }

        class Animales : ISalta, ICorre
        {
            public int Altura { get;  set; }
            public int Velocidad { get; set; }

             int  ISalta.score()
            {
                return 10;
            }
            int  ICorre.score()
            {
                return 20;
            }
        }


    }
}
