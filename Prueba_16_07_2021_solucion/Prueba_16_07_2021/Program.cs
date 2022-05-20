using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_16_07_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            Data[] _context =
            {
                new Data( "Pedro", "Gonzales", 25, "Hombre", "EC", false  ),
                new Data( "Juan", "Perez", 15, "Hombre", "EC", false ),
                new Data( "Alejadnro", "Troya", 30, "Hombre", "EEUU", false  ),
                new Data( "Erika", "Pesantes", 19, "Mujer", "COL", false  ),
                new Data( "Joss", "Anibal", 12, "Mujer", "EC", false  ),
                new Data( "Sebastian", "Rojas", 20, "Hombre", "EEUU", false ),
                new Data( "Jennyfer", "Granizo", 28, "Mujer", "EC", false  ),
            };


            /******** FILTAR MAYORES DE EDAD, OPCION 1 ********/
            //var personasFrom = from str in personas
            //                   where str.Edad > 18
            //                   //where str.Edad < 30
            //                   select new Data( str.Nombre, str.Apellido, str.Edad, str.Sexo, str.Pais, true);

            //foreach (var item in personasFrom)
            //{
            //    Console.WriteLine(item);
            //}


            /***** FILTAR MAYORES DE EDAD, OPCION 2 ********/
            //var personsForm = _context
            //    .Where(x => x.Edad > 18)
            //    .Select(str => new Data(str.Nombre, str.Apellido, str.Edad, str.Sexo, str.Pais, true));

            //foreach (var item in personsForm)
            //{
            //    Console.WriteLine(item);
            //}





            using (MainContext context = new MainContext())

            {

                IQueryable<Product> productsQuery = from product in context.Products select product;

                Console.WriteLine("Product Names:");

                foreach (var prod in productsQuery)

                {

                    Console.WriteLine(prod.Name);

                }

            }



        }
    }

    class Data
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string Sexo { get; set; }

        public string Pais { get; set; }

        public bool MayorEdad { get; set; }


        public Data(string nombre, string apellido, int edad, string sexo, string pais, bool mayorEdad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Pais = pais;
            this.MayorEdad = mayorEdad;
        }


        public override string ToString()
        {
            return String.Format($" Nombre: { Nombre }, Apellido: { Apellido }, Edad: { Edad }, Sexo: { Sexo }, Pais: { Pais }, Mayor de edad?: { MayorEdad } ");
        }


    }
}
