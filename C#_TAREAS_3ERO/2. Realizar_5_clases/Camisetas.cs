using System;
namespace _5_clases
{
    partial class Program
    {
        class Camisetas
        {
            public Camisetas( string valor ){
               Valor = valor;
            }
                 public string  Valor { get; set; }
           

             public void registrarValor( string Nombre ,string  Talla ,string  Color ){
                 Console.WriteLine( $"PRODUCTO REGISTRADO. Datos del producto: \n Nombre : { Nombre }, \n Talla : { Talla }, \n Color : { Color }, \n Valor: { this.Valor }" );
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
