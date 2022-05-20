using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion_De_Dependencias_Autofac
{
    public class User
    {

        private INotificationService _notificationService;

        public User(string username, INotificationService notificationService)
        {

             Username = username;
            _notificationService = notificationService;

        }

        public string Username { get; set; } 

        public void ChangeUserName( string newUserName )
        {

            Username = newUserName;
            _notificationService.NotifyUsernameChanged(this);

        }

    }

     
}
