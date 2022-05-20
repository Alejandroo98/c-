using System;

namespace Clase2_17_06_2021_
 
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Pedir 10 datos de una persona, bool, string, float, int, double, dateTime
            if( args[0] == "START")
            {
                Console.WriteLine("======= BIENVENIDO ========");
                Console.WriteLine("==== LLENA LOS CAMPOS =====");
                SaludoInicial(args);

            }else
            {
                Console.WriteLine("FIN DE LA APP");
            }
        }
        
        static void SaludoInicial( String[] args ) 
        {
            Person persona = new Person();
            Console.WriteLine("Ingresa tu primer nombre: ");
            persona.Name = Console.ReadLine();

            Console.WriteLine("Ingresa tu segundo nombre: ");
            persona.LastName = Console.ReadLine();
            
            Console.WriteLine("¿Eres mayor de edad?");
            persona.Adult = bool.Parse(Console.ReadLine());

            //"Solo para mayores de edad"
            if( persona.Adult == false ){
                Console.Write("==== FIN DEL PROGRAMA ====");
                return;
                // Console.ReadKey();
            }

            Console.WriteLine("Ingresa tu edad: ");
            persona.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa tu fecha de cumpleaños: ");
            persona.Date = Console.ReadLine();

            Console.WriteLine("Ingresa tu semestre: ");
            persona.Semester = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu direccion domiciliaria: ");
            persona.Address = Console.ReadLine();


            Console.WriteLine("Ingresa tu numero de telefono: ");
            persona.Phone = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Tipo de sangre: ");
            persona.Blood = Console.ReadLine();

            Console.WriteLine("Carrera que estudias: ");
            persona.Carrer = Console.ReadLine();
            
            Console.WriteLine(
                "==== REGISTRO EXITOSO ==== \n. Datos del registro:\n•Nombre: {0},\n•Apellido: {1},\n•Adulto: {2},\n•Age: {3},\n•Date: {4},\n•Semestre: {5},\n•Address: {6},\n•Phone: {7},\n•Blood: {8},\n•Carrer: {9}", persona.Name, persona.LastName, persona.Adult, persona.Age, persona.Date, persona.Semester, persona.Address, persona.Phone, persona.Blood, persona.Carrer
            );

            Console.ReadKey();
            Console.WriteLine("<<==== PARA SALIR PRESIONA UNA TECLA ====>>");
        }
    }
}


