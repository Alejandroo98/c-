using System;

namespace _5_clases
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Camisetas camisetas = new Camisetas("3");
            Abrigos abrigos = new Abrigos("5");
            Jeans jeans = new Jeans("8");
            Zapatos zapatos = new Zapatos("9");
            Gorras gorras = new Gorras( "10");
                Console.WriteLine("¡Bienvenido!. \n Elige la categoria que deseas guardar:  \n 1. Camisetas \n 2. Zapatos \n 3. Gorras  \n 4. Abrigos \n 5. Jeans  \n 6.Salir ");
                int opcion =  Convert.ToInt16(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                        string[] dataCamisetas = preguntas();
                        camisetas.registrarValor( dataCamisetas[0]  , dataCamisetas[1] , dataCamisetas[2] );
                        break;
                        case 2:
                        string[] dataZapatos = preguntas();
                        zapatos.registrarValor( dataZapatos[0]  , dataZapatos[1] , dataZapatos[2]  );
                        break;
                        case 3:
                        string[] dataGorras = preguntas();
                        gorras.registrarValor( dataGorras[0]  , dataGorras[1] , dataGorras[2] );
                        break;
                        case 4:
                        string[] dataAbrigos = preguntas();
                        abrigos.registrarValor( dataAbrigos[0]  , dataAbrigos[1] , dataAbrigos[2] );
                        break;
                        case 5:
                        string[] dataJeans = preguntas();
                        jeans.registrarValor( dataJeans[0]  , dataJeans[1] , dataJeans[2] );
                        break;
                        default:
                        Console.Write("Error: Escribe un numero validio");
                        break;
                    }
                    
                    string[] preguntas(){
                        Console.WriteLine("ingresa la marca: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Ingresa la talla: ");
                        string talla = Console.ReadLine();
                        Console.WriteLine("Ingresa el color: ");
                        string color = Console.ReadLine();
                        string[] data = { marca , talla , color };
                        return data;
                    }
                    
        }

                    

        
    }
}

  
/*Debes escribir un programa de consola con lenguaje C#, sobre los temas indicados en clase.

Cree 5 clases, cada una con 10 campos, sus propiedades correspondientes y 5 métodos.

Las clases deben enfocarse en algún juego de video, anime, tira cómica. ejemplo: Capitán Escudo ..

El programa debe cumplir:

El uso de "Console" los métodos de lectura y escritura, con sus sobrecargas.
La lectura de los parámetros enviados al programa y que se acceden desde args[].
Incluir los textos de la llamada al programa con los parámetros y que se obtiene en la consola, esto último incluir en el Readme
Subir los fuentes al git (no subir bin, obj)
El programa debe compilar.
El programa debe ejecutarse y los mensajes en pantalla deben ser claros.
Se deben respetar los estándares de programación.
Los nombres de las clases, objetos, métodos, atributos, variables, etcétera deben tener coherencia con el concepto que representan.*/
