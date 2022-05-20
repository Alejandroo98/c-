using System;

namespace Course_Udemy_18_6_21
{
    class ProgramTres
    {
        static void MainTres( string[] args )
        {
            /* ASI ES COMO PODEMOS HACER QUE UN PARAMETRO SEA OPCIONAL */
            //Console.WriteLine( opcional(  10 ,  8 ) 
            //uno
            //dos
            //tres
            //Console.WriteLine( opcional(  10 ,  8 ) 
            //bucle();
            // game();
            // doWhile();
        }
        
            /* ( EL PARAMETRO OPCIONAL TIENE QUE IR SIEMPRE AL FINAL ) */
        static void doWhile()
        {

            int num = 10;
            
            do 
            {
                Console.WriteLine("Hola");
            } while( num < 5 );
        }
            
        private static int opcional( int numUno , int numDos , int numTres = 0 )

        {
            return numUno + numDos + numTres;
        }

        static void bucle()
        {
            //Un peque�o ejemplo usando un while, como te puedes dar cuenta el valor que evaluamos del while lo cambiamos dentro del mismo while para que este deje de seguir ejecutandose.
            string pregunta = "no";
            while( pregunta == "no" )
            {
                Console.WriteLine("si - no");
                string read = Console.ReadLine();
                pregunta = read;
            }
        }

        static void game()
        {
            Random random = new Random();

            int numEvaluar = random.Next( 1, 15 ) ;

            Console.WriteLine("Adivina el numero de entre el 1 y el 15: ");
            
            int numeroUsuario = int.Parse(Console.ReadLine());
            
            int intentos = 0;
            
            while( numeroUsuario != numEvaluar )
            {
                intentos++;
                
                if( numeroUsuario > numEvaluar ) Console.WriteLine("EL el numero es mas bajo");

                if( numeroUsuario < numEvaluar ) Console.WriteLine("EL el numero es mas alto");
                Console.WriteLine("Numero incrrecto, sigue intentando.");

                numeroUsuario = int.Parse(Console.ReadLine());
            };
            
            Console.WriteLine( intentos );
            Console.WriteLine($"Bien echo!, el numero correcto es: { numeroUsuario }");

        }

    }

}
