using System;
namespace _5_clases
{
    class Gorras
    {

        public Gorras( string valor ){
               Valor = valor;
            }
                 public string  Valor { get; set; }
           

             public void registrarValor( string Nombre ,string Talla ,string Color ){
                 Console.WriteLine( $"PRODUCTO REGISTRADO. Datos del producto: \n Nombre : { Nombre }, \n Talla : { Talla }, \n Color : { Color }, \n Valor: { this.Valor }" );
            }
        
    }

    }
