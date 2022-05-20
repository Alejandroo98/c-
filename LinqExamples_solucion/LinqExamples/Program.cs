using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arregloEnteros = { 1, 2, 3, 4, 2, 2, 100, 12, 67, 45, 5, 6, 7, 8 };

            //// Obtener numeros ordenados
            //IEnumerable<int> list = from d in arregloEnteros
            //                        where d == 2 || d == 1
            //                        orderby d
            //                        select d;


            //foreach (var a in list)
            //{
            //    Console.WriteLine(a);
            //    Console.ReadKey();
            //}


            Complejo[] list =
            {
                new Complejo(1, "patito"),
                new Complejo(666, "diablito"),
                new Complejo(99, "perro"),
                new Complejo(125, "ave"),
                new Complejo(456, "foca")
            };


            var listDiablo = (from d in list
                              where d.Cadena == "diablito"
                              select d).FirstOrDefault(); //FirstOrDefault(), sirve para regresar el elemento buscado o null en caso contrario 

            Console.WriteLine( listDiablo.Imprime() );


            var ordenarPorNumero = from d in list
                                   orderby d.Numero
                                   select d;


            foreach (var order in ordenarPorNumero)
            {
                Console.ReadKey();
                Console.WriteLine( order.Imprime() );
            }


        }

    }


    public class Complejo
    {
        public int Numero { get; set; }
        public string Cadena { get; set; }


        public Complejo(int Numero, string Cadena)
        {
            this.Numero = Numero;
            this.Cadena = Cadena;
        }

        public String Imprime()
        {

            string data = $"{ Numero } { Cadena }";
            Console.WriteLine( data );
            Console.ReadKey();
            return data;
        }



    }



}
