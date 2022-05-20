using System;

namespace CURSO_YT
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXCEPCIONES */
            //Puedes ir descomentado los nombres de los metodos para que los vayas comprovando;
            try
            {
                Console.WriteLine( throwException( 10 ) );
            }
            catch (  Exception error )  //Excepcion general
            {
                Console.WriteLine("A ocurrido un error");
                Console.WriteLine($"Este es el error: {  error.Message }");
            }

            //excepcionesChecked();
            //excepciones();
            /* *FIN EXCEPCIONES */
        }

        static void excepciones()
        {

            Random random = new Random();
            int numeroRanmdon = random.Next(1, 10);
            int numUser = 0;
            int intentos = 0;

            do
            {
                intentos++;

                try
                {

                    Console.WriteLine("Escribe un numero entre el 1 y el 10: ");

                    numUser = int.Parse(Console.ReadLine());

                    if (numUser > numeroRanmdon) Console.WriteLine("EL numero es mas bajo");

                    if (numUser < numeroRanmdon) Console.WriteLine("EL numero es mas alto");


                }
                /* Si deseas no especificar el tipo de error puedes usar un tipo de error generico, es decir que no importe el tipo de error igual lo tomara, tiene que poner entro los parentesis del catch "Exception" o puedes tambien borrar el parentesis y haria la misma funcion */
                catch (  SystemException error) //exception -> Tipo de error general. //SystemException -> este error se ejcuta cuando no puede convertir una cadena de texto a un entero
                {
                    Console.WriteLine("Ingresa un numero valido");
                    Console.WriteLine($"El error es este: { error.Message }");
                }
                catch ( Exception error) when (error.GetType() != typeof( FormatException ))//( excpecion con filtro ) Esta es una excpecion cuando existe un tipo de exepcion especifica, es decir quiero que me atrapes todas las excpeciones perro quiero que lo hagas cuando este conincida con esto. // A ver te explico, esto lo hace es como primero atrapar todas las excepciones, luego por medio del error.getType() obtienes el error y dices que queries ejecutar este catch cuando el error sea distino a FormatException, es decir quiero que se ejecute con todas las excepciones menos con esta FormatException.
                {

                }
                //catch ( OverflowException error ) //Este es otro tupo de error, se ejecuta cuando ingresamos un numero muy alto;
                //{
                //    Console.WriteLine("El numero es demasiado alto");
                //}


            } while (numeroRanmdon != numUser);

            Console.WriteLine($"El numero de intentos fue: { intentos }");

        }


        static void excepcionesChecked()
        {

            checked //Esto lo explico mas abajo, pero en resumen el checked nos sirve para que sea mas minusioso el compiladir y evitar errores de desbordamientos no controlados. 
            /* Tambien tenemos unchecked, y esto lo que hace es que el compilador no evalue esas o esa linea */
            /* puedes encerrar por bloques -> checked {}, o puedes hacerlo tambien por lineas -> checked( 5 + 10 ), por cirto esto solo valo con int y long  */
            {
                try
                {
                    int numero = int.MaxValue; //Es lo que hace es devolverte el numero mas alto que permite el "int"

                    int desbordamiento = numero + 20; //Esto deveria dar un error por que estoy sumandole al numero maximo ms 20 mas, peeero no da error, por que lo hace el  es ponerlo en negatico, para que se lanse el error lo que tenemos que hacer es envolver al codigo en un checked, esto lo que hara es que revise el  compilador minusiosamente lsa lineas y no ocurra un desbordamiento, o tambien lo podemos hacer desde el explorador de soluciones en propiedades. 

                    Console.WriteLine(desbordamiento);
                }
                catch (Exception)
                {
                    Console.WriteLine("A habido un error");
                }

            }
        }


        public static string throwException( int dia )
        {

            switch ( dia )
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Lunes";
                case 3:
                    return "Lunes";
                case 4:
                    return "Lunes";
                case 5:
                    return "Lunes";
                default:
                    throw new ArgumentOutOfRangeException(); //Lo que hacemos asi es generar un error especifico, lo sacamos de la documentacion -> "https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception?view=net-5.0"
            }

        }



    }
}
