using System;

namespace Course_Udemy_18_6_21
{
    class ProgramEje
    {
        static void Herencia(string[] args)
        {


            Caballo nombreCaballo = new Caballo();
            Humano Juan = new Humano();
            Gorilla Copito = new Gorilla();

            nombreCaballo.cuidarCrias();
            
        }

    }

    /* SIEMPE LAS CLASES HEREDARAN DE UNA CLASE QUE LA LLAMAN "SUPERCLASE SOCMICA" ESTA SIEMPRE VA A ESTAR POR ENCIMA DE CUALQUIERA QUE HAYAS CREADO TU */

    class Mamiferos
    {

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que puedan por si solas");
        }

        
    }

    class Caballo : Mamiferos //Asi es como se hereda.
    {
        public void galopar()
        {
            System.Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public void pensar()
        {
            System.Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorilla : Mamiferos 
    {
        public void terpar()
        {

            System.Console.WriteLine("Soy capaz de trepar");
            
        }
    }
    
}