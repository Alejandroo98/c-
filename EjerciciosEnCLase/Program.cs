using System;
using System.Collections.Generic;
using System.IO;

namespace EjerciciosEnCLase
{
    class Program
    {
        static void Main(string[] args)
        {   
            string cabecera = "<?xml version ='1.0' encoding='UTF-8'standalone='yes' >";
            FileStream file = File.Create("./Created.xml"); //Como paremetro ingresas la direccion en donde quieres que guarde el archivo 
        }

    }

    interface IToXml
    { 
        string ToXml();
    }

    public class Heroe : IToXml //Si es clase => herenca, si es interfas
    {
        //Utilizar boo, fateTime, float, int, double, string
        public string Name { get; set; }
        public int Ki { get; set; }
        public Caracter Caracter { get; set; }
        public Fase Fase { get; set; }
        public Heroe Amigo { get; set; }
        public Villano Enemigo { get; set; }
        public Ubicacion Ubicacion { get; set; }

        // public Heroe[] Hijos{ get; set; } //Hijos vector - Lo puedes hacer de estas tres formas
        // public List<Heroe> Hijos { get; set; } //Hijos lista - Lo puedes hacer de estas tres formas
        // public Collection<Heroe> Hijos{ get; set; } //Hijos coleccion - Lo puedes hacer de estas tres formas
        


        public string ToXml()
        {
            return $"<heroe><name>{ Name }</name><ki>{ Ki }</ki><carecter>{ Caracter }</carecter>" + $"{ Enemigo.ToXml() }</heroe>";
        }
        
    }


    public enum Caracter 
    { 
        Jovial,
        Enojado,
        Violento,
    }
    

    public class Ubicacion : IToXml
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int PosicionZ { get; set; }
        public DateTime PosicionTiempo { get; set; }

        public string ToXml()
        { 
            return $"<ubicacion><posicion>{ PosicionX }</posicion></ubicacion>"; //{throw new NotImplementedException()
        }
        
    }


    public class Fase
    { 
        public string Name { get; set; }
    }
    

    public class Villano : IToXml
    {
        public string Name { get; set; }
        public int Ki { get; set; }

        public string ToXml()
        { 
             return $"<vaillano><name>{ Name }</name><ki>{ Ki }</ki></vaillano>";
        }

    }

    
    
}