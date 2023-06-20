using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdEstatusFlujo
    {
        public OfdEstatusFlujo()
        {
            OfdSolicitudDocFiscals = new HashSet<OfdSolicitudDocFiscal>();
        }

        public string IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public string FlagPendiente { get; set; }
        public string FlagAprobado { get; set; }
        public string FlagRechazado { get; set; }
        public string FlagEnviado { get; set; }
        public bool FlagMail { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }

        public virtual ICollection<OfdSolicitudDocFiscal> OfdSolicitudDocFiscals { get; set; }
    }
}
