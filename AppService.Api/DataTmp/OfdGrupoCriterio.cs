using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdGrupoCriterio
    {
        public int IdGrupoCriterio { get; set; }
        public short IdGrupoTipoDocumento { get; set; }
        public short IdCriterioBusqueda { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual OfdCriterioBusquedum IdCriterioBusquedaNavigation { get; set; }
        public virtual OfdGrupoTipoDocumento IdGrupoTipoDocumentoNavigation { get; set; }
    }
}
