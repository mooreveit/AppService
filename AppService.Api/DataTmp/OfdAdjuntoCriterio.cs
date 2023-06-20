using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdAdjuntoCriterio
    {
        public long IdAdjuntoCriterio { get; set; }
        public long IdAdjunto { get; set; }
        public short IdCriterioBusqueda { get; set; }
        public string Valor { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual OfdAdjunto IdAdjuntoNavigation { get; set; }
        public virtual OfdCriterioBusquedum IdCriterioBusquedaNavigation { get; set; }
    }
}
