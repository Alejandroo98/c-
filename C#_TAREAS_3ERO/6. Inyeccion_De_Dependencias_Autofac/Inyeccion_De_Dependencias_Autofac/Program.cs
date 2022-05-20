using System;
using Autofac;

namespace Inyeccion_De_Dependencias_Autofac
{
    public class Program
    {

        public string Nombre { get; set; }

        static void Main(string[] args)
        {

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ConsoleNotification>().As<INotificationService>();

            var container = containerBuilder.Build();

            var notificationService = container.Resolve<INotificationService>();

            var userOne = new User("Alejandro", notificationService);
            userOne.ChangeUserName("Jefferson");

            Console.ReadKey();

        }
    }
}
