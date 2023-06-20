using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdCambioDiseno
    {
        public OfdCambioDiseno()
        {
            OfdSolicitudDisenoCambios = new HashSet<OfdSolicitudDisenoCambio>();
        }

        public int IdCambio { get; set; }
        public string NombreCambio { get; set; }
        public string IdTipoCambio { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual OfdTipoCambioDiseno IdTipoCambioNavigation { get; set; }
        public virtual ICollection<OfdSolicitudDisenoCambio> OfdSolicitudDisenoCambios { get; set; }
    }
}
