using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prueba15_07_2021.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba15_07_2021.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Conyuge> Conyuges { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Hijo> Hijos { get; set; }

    }
}
