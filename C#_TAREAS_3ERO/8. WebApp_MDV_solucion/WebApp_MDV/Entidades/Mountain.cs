using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_MDV.Entidades
{
    public class Mountain
    {

        public int MountainId { get; set; }

        [DisplayName("Nombre de la montaña")]
        public string Nombre { get; set; }

        [DisplayName("Altitud de la montaña")]
        public int Altitiud { get; set; }

    }
}
