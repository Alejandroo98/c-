using System.Linq;

namespace Arboles_tarea_28_06_2021
{
    internal class ControladorArbol
    {
        internal int ContarHojas( Nodo nodo )
        {
            int acumulador = 0;
            foreach ( Nodo actual in nodo.Hijos )
            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContarNodos( Nodo nodo )
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Hijos.Count;
            }
            return acumulador;
        }
        
        internal int ContarNiveles( Nodo nodo ){
         int acumulador = 0;
         foreach ( Nodo actual in nodo.Hijos )
         {
             acumulador += actual.Valor.Count();
         }
            return acumulador;
        }
       
    }
}