using System;
using System.Linq;
using WebApplicationTest.Entities;

namespace WebApplicationTest.Models
{
    //DTO => Data Transfer Objetc

    public class EmpleadosSimple
    {

        public int Empleadoid { get; set; }
        public string Nombre { get; set; }
        public int Apellido {  get; set; }
        public float Salario { get; set; }
        public DateTime Nacimiento { get; set; }
        public double Edad { get; set; }
        public int Creditos { get;  set; }

        public static EmpleadosSimple Convertir( Empleado empleado )
        {
            return new EmpleadosSimple
            {
                Empleadoid = empleado.Empleadoid,
                Apellido = empleado.Apellido,
                Nombre = empleado.Nombre,
                Edad = empleado.Edad,
                Nacimiento = empleado.Nacimiento,
                Salario = empleado.Salario,
                Creditos = empleado.Cursos.Sum(x => x.NumeroEnteros)
            };
        }


    }

}
