using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion_De_Dependencias_Autofac
{
    public interface INotificationService
    {
        void NotifyUsernameChanged(User user);
    }
}
