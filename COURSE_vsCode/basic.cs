using System;

namespace Course_Udemy_18_6_21
{
    class Pedro
    {
        static void Ejeplo(string[] args)
        {
            // int year = Convert.ToInt32(16);
            // double decimales = 2.0;
            // string name = "Alejo";
            // String names = "Alejo Pedro";
            // decimal decimals = 5.1M; //La M le indica que no es un double si no un decimal, a estas letras les llamamos prefijos;
            // float flotante = 8.1F; //No olvides agregarle su prefijo;
            // bool bolenado = true;
            // char letra = 'A'; //char solo puede guardar un solo caracter, y no puedes ponder entre comillas dobles o te marcara como error, ponte entre comillas simples -> '';
            // double doble = 5.325;       
            // Console.WriteLine("Numero: {0} {1} {2}",year, decimales, name, names, decimals, flotante, bolenado, letra, doble);
            // string mundo = "mundo";
            // var eje = $"Hola { mundo }";
            // Console.WriteLine( eje );
            // Console.Write( 5 * 5 );
            // Console.Write( 5 / 2 ); //Ojo con esto, el resultado sera 2, para que tome encuenta los decimales tienes que hacerlo asi -> 5.0 / 2.0
            // Console.WriteLine( 10 % 3 ); //Aqui lo que imprimira sera el residuo, es decir 10 dividido para 3, a 3, y nos quedaria 1. Ahora 9 % 3, la respuesta sera 0, por que no quera nada de residuo    
            /* ITERPOLACION DE STRING -> $"Hola { variable }" */

            /*  RECUEDA QUE SIEMPRE TIENES QUE DECIRLE A C# QUE TIPO DE VALOR VAS A GUARDAR EN UNA VARIABLE, YA SEA BOOL, STRING ETC...  */
            //Si dices que va hacer de tipo string, durante la ejecucion no podras cambiar este tipo de variable.
            // string numero;
            // numero = "10"; //Bien!
            // numero = 10; //Error
            // Console.WriteLine( numero );

            /* IMAGINA QUE TIENES QUE CAMBIAR EL TIPO DE VALOR QUE GUARDARAS EN UNA VARIABLE, ESTO LO PUEDES HACER ASI */

            // var numeroDecimal = 6.1;
            //Lo que hace esto es pasar un valor decimal a un tipo entero, para que no de error, esto es bastante comun hacerlo;
            // int entero = ( int ) numeroDecimal; //Al valor que lo quieres pasar lo pones entre parentesis antes del valor a convertir
            // Console.WriteLine( entero );
            // string hola = "12";
            // int num = Convert.ToInt32( hola );
            // Console.WriteLine( num );

            /* PARSEAR O CONVERTIR DE ARREGLO A ENTERO Y AL CONTRARIO */
            // Console.WriteLine(" Ingresa dos numeros: ");
            // int num1 = Convert.ToInt16( Console.ReadLine() );
            // int num2 = int.Parse( Console.ReadLine() ); //Tienes estas dos opciones para convertir de arreglo a int
            // Console.WriteLine( $"La suma total es:  {num1 + num2} " );

            /* CONSTANTES   */
            // const int PC = 5; //Por convencion escribimos los nombres de las constantes en mayusculas
            // const string NAME = "Alejo";
            // Console.WriteLine( $"{PC}  {NAME}" );
            
            /* EJERCICIO CON CONSTANTES */
            //Lo que haremos es calculaer el radio de un circulo;
            // const double PI = 3.1416; //
            // Console.WriteLine( "Escribe la medida del radio: " );
            // double radio = double.Parse( Console.ReadLine() );

            // double area = radio * radio * PI;
            //Esto es lo mismo de arriba pero utulizando el metodo Math.
            // double area = Math.Pow( radio , 2 ) * PI; // el POW lo que hace es smiplemente elevar un numero, en este caso el numero de radio lo elevamos al cuadrado, por eso el dos;
            // Console.WriteLine( $"El area del circulo es: {area}" );


            /* METODOS O FUNCIONES ( AMBOS SON LO MISMO ) */
            // int sumaNumeros( int num1 ,int num2 ){
            //     return num1 + num2;
            // };

            // string saludar( string name, string lastName ){
            //     return $"Hola { name } {lastName} ";
            // };

            // void despedirse( string name, string lastName ){
            //     Console.WriteLine( $"Hasta luego { name } { lastName }" );
            // };

            // Console.WriteLine( sumaNumeros( 5 , 2 ) );
            // Console.WriteLine( saludar( "Alejo" , "Alava" ) );
            //  despedirse( "Alejo" , "Alava" );

            /* VIDEO QUE SIGUE -> https://www.youtube.com/watch?v=N1OEk4gNFeQ */
            // 19-06-2021            


            /* =======COMO LLAMAR MEOTODOS( FUNCIONES ) ====*/
            // Console.WriteLine($"La suma total es: { metodo(5 , 6) }") ;

            /* ==========  SOBRECARGA ============ */
            //Aqui en C# si que podemos crear varios metodos(funciones) con el mismo nombre, como lo diferenciamos es por medjio de los parametros.
            Console.WriteLine(Sobrecarga( "Alejo" ));
            Console.WriteLine(Sobrecarga( 15 ));
            Console.WriteLine(Sobrecarga( "Eje" , "Eje" ));
            
            
            

            
            
        }

        /* =====AQUI SI PUEDES CREAR METODOS CONO UN MISO NOMBRES, SOLO TINES QUE CAMBIAR LA CANTIDAD DE PARAMETROS O EL TIPO DE DATO DE ESTOS PARAMETROS */
        static string Sobrecarga( string nombre ) =>  $"Hola mi nombre es: { nombre }";
        static string Sobrecarga( int edad ) =>  $"Hola mi edad es: { edad }";
        static string Sobrecarga( string papa , string mama ) =>  $"Los nombres de mi padres son : { papa } { mama }";



        // static int metodo( int num1 , int num2 ){
        //     return  num1 + num2;
        // }

        //PUEDES HACER UNA METODO(FUNCION) COMO EN JS, CUANDO SOLO TIENES UNA LINEA DE CODIGO DENTRO DEL METODO NO HACE FALTA AGREGARLE UN RETURN Y LO PUEDES HACER EN UNA SOLA LINEA;
        static int metodo( int num1 , int num2) => num1 + num2;
        
        

        
    }
}


/* VIDEO QUE SIGUE -> https://www.youtube.com/watch?v=Rmnz3xUrrks */