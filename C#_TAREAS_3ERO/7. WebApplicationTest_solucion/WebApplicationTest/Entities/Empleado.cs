using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WebApplicationTest.Models;

namespace WebApplicationTest.Entities
{
    public class Empleado
    {

        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Salario { get; set; }
        public DateTime Nacimiento { get; set; }
        [NotMapped]
        public double Edad { get { return DateTime.Now.Subtract(Nacimiento).TotalDays / 365; } }

        [ForeignKey("Departamento")]
        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set; }
        public Conyuge Conyuge { get; set; }
        public List<Hijo> Hijos { get; set; }

        public List<Curso> Cursos { get; set; } //De muchos a muchos

        public EmpleadosSimple ConvertirEnEmpleadoSimple()
        {
            return new EmpleadosSimple
            {
                Empleadoid = Empleadoid,
                Apellido = Apellido,
                Nombre = Nombre,
                Edad = Edad,
                Nacimiento = Nacimiento,
                Salario = Salario,
                Creditos = Cursos == null ? 0 : Cursos.Sum(x => x.NumeroEnteros)
            };
        }

    }

}
