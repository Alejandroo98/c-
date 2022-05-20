using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_MDV.Entidades;

namespace WebApp_MDV.Data
{
    public class MainContext : DbContext
    {

        public DbSet<Mountain> Mountains{ get; set; }


        public MainContext( DbContextOptions<MainContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mountain;Integrated Security=True;");  //Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //UseSqlite(@"Data Source=C:/");
        //}
    }


}
