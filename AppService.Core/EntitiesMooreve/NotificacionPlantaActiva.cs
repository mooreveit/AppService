using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class NotificacionPlantaActiva
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public bool? Enviado { get; set; }
    }
}
