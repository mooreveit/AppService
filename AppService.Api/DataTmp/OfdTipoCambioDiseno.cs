using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdTipoCambioDiseno
    {
        public OfdTipoCambioDiseno()
        {
            OfdCambioDisenos = new HashSet<OfdCambioDiseno>();
            OfdSolicitudDisenos = new HashSet<OfdSolicitudDiseno>();
        }

        public string IdTipoCambio { get; set; }
        public string NombreTipoCambio { get; set; }
        public short IdPonderacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<OfdCambioDiseno> OfdCambioDisenos { get; set; }
        public virtual ICollection<OfdSolicitudDiseno> OfdSolicitudDisenos { get; set; }
    }
}
