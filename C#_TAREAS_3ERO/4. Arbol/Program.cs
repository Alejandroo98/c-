using System;

namespace Arboles_tarea_28_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {
                Valor = "/",
                nivel = 0,
                Hijos = {
                    new Nodo {
                        Valor = "*",
                        Hijos = {
                            new Nodo {
                                Valor = "5"
                            },
                            new Nodo {
                                Valor = "10"
                            }
                        }
                    },
                    new Nodo {
                        Valor = "-",
                        Hijos = {
                            new Nodo {
                                Valor = "6"
                            },
                            new Nodo {
                                Valor = "8"
                            }
                        }
                    },
                    new Nodo {
                        Valor = "+",
                        Hijos = {
                            new Nodo {
                                Valor = "12"
                            },
                            new Nodo {
                                Valor = "14"
                            }
                           
                        }
                    }
                },
            };

            ControladorArbol controladorArbol = new ControladorArbol();
            Console.WriteLine($"Hojas del arbol: {controladorArbol.ContarHojas(raiz)}");
            Console.WriteLine($"Niveles del arbol: {controladorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"Nodos del arbol: {controladorArbol.ContarNodos(raiz)}");

        }
    }
}
