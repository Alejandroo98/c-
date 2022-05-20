using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTest.Entities
{
    public class Conyuge
    {
        public int ConyugeId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //[NotMapped]
        //public string NombreCompleto { get { return $"{ Nombre } { Apellido }"; } }

        [ForeignKey("Empleado ")] //Como ves esta es la calve foranea de Empleado
        [DisplayName("Empleado")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

    }


}
