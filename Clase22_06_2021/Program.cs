using System;

namespace Clase22_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais = new Pais();
            string[] provincias = { "Pichicha" , "Cotopxi" , "Azuay" , "Guayas" };
            pais.provincias_pais = provincias;
            for (int i = 0; i < pais.provincias_pais.lenght; i++)
            {
                Console.WriteLine(  pais.provincias_pais[i] );
            }
            // Console.WriteLine("Hello World!");
        }
    }

 
}
