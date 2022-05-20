using System.Collections.Generic;

namespace Arboles_tarea_28_06_2021
{
    class Nodo
    {
        public List<Nodo> Nodos
        {
            get;set;
        } = new List<Nodo>();
        public string Valor{ get; set; }
        public List<Nodo> Hijos
        {

            get; set;
        } = new List<Nodo>();
        public int nivel;
        
        public int nodoRaiz = 1;
    }
}
