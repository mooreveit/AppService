using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdAprobacionDiseno
    {
        public long IdSolicitud { get; set; }
        public string EmailCliente { get; set; }
        public string Cargo { get; set; }
        public long? Cedula { get; set; }
        public string ObsConsultor { get; set; }
        public string ObsCliente { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaAgrega { get; set; }
        public decimal IdTicket { get; set; }
        public bool FlagDescargoDiseno { get; set; }

        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
