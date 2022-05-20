using System;

namespace Arboles_nodos_clase_24_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var raiz = new Nodo()
            {
                 Valor = "*", 
                 Hijos =
                 {
                       new Nodo
                        { 
                                Valor = "8"
                        },
                       new Nodo
                        { 
                                Valor = "5"
                        }
                 }
            }; 

            //Resultado esperado => 8*5
            ManejadorArbol ManejadorArbol = new ManejadorArbol();
            ManejadorArbol.ImprimirArbol( raiz );
            // Console.WriteLine(  );
            
        }
    }

    
    
    
    
}
