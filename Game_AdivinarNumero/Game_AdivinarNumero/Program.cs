using System;

namespace Game_AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            game(); 
        }

        static void game()
        {
            //Este es un juegito que conciste en adivinar el numero que el metodo randon en un rago de 1 al 15 y al adivinar este numero te saldra la cantidad de intentos que realizaste"
            Random random = new Random();

            int randmonRange = random.Next(1, 15);

            Console.WriteLine("Escribe un: ");
            int numeroUsuario = int.Parse( Console.ReadLine() );

            int contador = 0;

            while ( numeroUsuario != randmonRange )
            {
                contador++;
                Console.WriteLine("=== Numero incorrecto ===");
                Console.WriteLine("Intenta de nuevo: ");
                numeroUsuario = int.Parse( Console.ReadLine() );
            }

            Console.WriteLine($"==== Numero de intentos total: { contador } ===");



        }


    }
}
