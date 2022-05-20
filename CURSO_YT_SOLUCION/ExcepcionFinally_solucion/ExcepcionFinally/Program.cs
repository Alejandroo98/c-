using System;
using System.IO;

namespace ExcepcionFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader archivo = null;

            try
            {

                string linea;

                int contador = 0;

                string path = @"C:\Users\USER\Desktop\C#\CURSO_YT_SOLUCION\EjemploExcpecionFinally.txt";

                archivo = new StreamReader( path );

                while (( linea = archivo.ReadLine()) != null )
                {
                    Console.WriteLine( linea );

                    contador++;

                }

            }
            catch (Exception error)
            {

                Console.WriteLine("Error con la lectura del archivo");

            }
            finally
            {

                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexion con el fichero cerrada");

            }

        }
    }
}
