using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CrmNotificacionActividade
    {
        public decimal IdNotificacion { get; set; }
        public long IdSeguimiento { get; set; }
        public string Para { get; set; }
        public string Cc { get; set; }
        public string Cuerpo { get; set; }
        public DateTime FechaHoraEnvio { get; set; }
    }
}
