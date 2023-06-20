using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdGrupoTipoDocumento
    {
        public OfdGrupoTipoDocumento()
        {
            OfdGrupoCriterios = new HashSet<OfdGrupoCriterio>();
            OfdTipoDocumentos = new HashSet<OfdTipoDocumento>();
        }

        public short IdGrupoTipoDocumento { get; set; }
        public string NombreGrupo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<OfdGrupoCriterio> OfdGrupoCriterios { get; set; }
        public virtual ICollection<OfdTipoDocumento> OfdTipoDocumentos { get; set; }
    }
}
