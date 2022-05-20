using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using WebApplicationTest.Data;
using WebApplicationTest.Entities;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EmpleadosSimple> Empleados()
        {
            IQueryable<Empleado> consulta = _context.Empleados.Include(e => e.Cursos);
            List<Empleado> empleados = consulta.ToList();

            return empleados.Select(e => e.ConvertirEnEmpleadoSimple());

        }

        public IEnumerable<EmpleadosSimple> EmpleadosPaginados(int pagina, int tamano)
        {
            var salto = (pagina - 1) * tamano;
            var empleados = _context.Empleados.Skip(salto).Take(tamano).ToList();
            return empleados.Select(e => e.ConvertirEnEmpleadoSimple());
        }


        public Empleado[] Data()
        {
            var resultado = from x in _context.Empleados
                            where x.Apellido == "Alava"
                            select x;
            return resultado.ToArray();

            //var resultado1 = _context.Empleados.Where(x => x.Apellido == "Alava");
            //return resultado1.ToArray();

        }

        public object Ejemplo1()
        {
            var consulta = from e in _context.Empleados
                           from h in _context.Hijos
                           where e.Empleadoid == h.EmpleadoId
                           select e;

            return consulta.ToList();

            var consulta0 = from e in _context.Empleados
                            join h in _context.Hijos
                            on e.Empleadoid equals h.EmpleadoId
                            select new { e.Apellido, NumeroHijos = e.Hijos.Count };


            var consulta1 = from e in _context.Empleados
                            from h in _context.Hijos
                            where e.Empleadoid == h.EmpleadoId
                            select new { e.Apellido, NumeroHijos = e.Hijos.Count };
            return consulta1.ToArray();

            var consulta2 = _context.Empleados
                .Include(e => e.Hijos)
                .Select(e => new { e.Apellido, NumeroHijos = e.Hijos.Count });
        }

        public Empleado Crear( [Bind("EmpleadoId,Salario,Nombre,Apellido,DepartamentoId")] Empleado empleado)
        {
            _context.Add(empleado);
            _context.SaveChanges();

            //LazyLoad
            //EagerLoader
            //ExplicityLoad
            _context.Entry(empleado).Collection(e => e.Hijos).Load();
            _context.Entry(empleado).Reference(e => e.Departamento).Load();

            return empleado;
        }

        public void Samples()
        {
            using ( var otroContexto = new ApplicationDbContext( null ) )
            {

                if ( otroContexto.Cursos.Any(c => c.NumeroEnteros > 100) )
                {
                    //TODO: Que bueno! 
                }

            }

        }

    }

}
