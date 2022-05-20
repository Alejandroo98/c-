
namespace Inyeccion_dependenciasYT
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTO ESTA MAL
            //Cantinero cantinero = new Cantinero();
            //cantinero.Preparar();

            //FORMA CORRECTA
            IBebida piñaColada = new MediasDeSeda();
            Cantinero cantinero = new Cantinero( piñaColada );
            cantinero.Preparar();
        }
    }
}
