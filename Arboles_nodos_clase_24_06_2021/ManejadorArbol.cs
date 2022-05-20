using System;
using System.Linq;

namespace Arboles_nodos_clase_24_06_2021
{

    class ManejadorArbol
    {
        public string ImprimirArbol( Nodo nodo )
        {
            //Analiza el comportamiento de una hoja
            if( !nodo.Hijos.Any() )
            {
                return nodo.Valor;
            }
            
            throw new NotImplementedException();
        }
    }

}