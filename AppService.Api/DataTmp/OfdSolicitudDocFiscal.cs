using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdSolicitudDocFiscal
    {
        public long IdSdf { get; set; }
        public long IdNumeracion { get; set; }
        public string IdEstatus { get; set; }
        public string EmailCliente { get; set; }
        public string Cargo { get; set; }
        public long Cedula { get; set; }
        public bool FlagSaltoNumeracion { get; set; }
        public string ObsvConsultor { get; set; }
        public string ObsvCliente { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime FechaAgrega { get; set; }
        public decimal? IdTicket { get; set; }

        public virtual OfdEstatusFlujo IdEstatusNavigation { get; set; }
        public virtual PrcNumeracionFiscal IdNumeracionNavigation { get; set; }
    }
}
