using System;

using System.Collections.Generic;

namespace Clase_22_06_2021
{
    class Program
    {
        public static void Main(string[] args)
        {

            Pais pais = new Pais();

            Provincia provinciaUno = new Provincia();
            provinciaUno.Nombre = "Guayas";

            Provincia provinciaDos = new Provincia();
            provinciaDos.Nombre = "Pichincha";
            
            pais.Provincias = new List<Provincia>(){ provinciaUno , provinciaDos };

            Canton cantonUno = new Canton();
            cantonUno.Nombre = "Mejia";
            
            Canton cantonDos = new Canton();
            cantonDos.Nombre = "Cayambe";
             
            provinciaDos.Cantones = new List<Canton>(){ cantonUno , cantonDos };

            Parroquia parroquiaUno = new Parroquia();
            parroquiaUno.Nombre = "San Sebastian";
            parroquiaUno.Habitantes = 200;
            
            Parroquia parroquiaDos = new Parroquia();
            parroquiaDos.Nombre = "Gonzales Suarez";
            parroquiaDos.Habitantes = 500;

            cantonUno.Parroquias = new List<Parroquia>(){ parroquiaUno , parroquiaDos };

            Console.WriteLine($"Habitantes totales en 2 parroquias: {pais.ObtenerNumeroDeHabitantes()}");

        }
    }
}
