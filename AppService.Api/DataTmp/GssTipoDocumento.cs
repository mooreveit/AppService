using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssTipoDocumento
    {
        public GssTipoDocumento()
        {
            GssAdjuntoTareas = new HashSet<GssAdjuntoTarea>();
        }

        public short IdTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public bool Inactivo { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<GssAdjuntoTarea> GssAdjuntoTareas { get; set; }
    }
}
