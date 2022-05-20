using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba15_07_2021.Entities
{
    public class Conyuge
    {
        public int ConyugeId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; } //Prop para FK

        public Empleado Empleado { get; set; }



    }


}
