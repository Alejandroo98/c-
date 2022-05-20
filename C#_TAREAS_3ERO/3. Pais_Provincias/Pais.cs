using System.Collections.Generic;

namespace Clase_22_06_2021
{
    class Pais
    {
        public int PaisId { get; set; }
        
        public string Nombre { get; set; }

        public List<Provincia> Provincias { get; set; } = new List<Provincia>();
        
        public  int ObtenerNumeroDeHabitantes()

        {
            int acumulador = 0;
            
            foreach (Provincia habitantes in Provincias)
            {
                acumulador = acumulador + habitantes.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}
