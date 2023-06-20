using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class SegRol
    {
        public SegRol()
        {
            OfdRolTipoDocumentos = new HashSet<OfdRolTipoDocumento>();
            SegUsuarioRols = new HashSet<SegUsuarioRol>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IdPrograma { get; set; }
        public string DescripcionRol { get; set; }
        public string AbreviadoRol { get; set; }

        public virtual ICollection<OfdRolTipoDocumento> OfdRolTipoDocumentos { get; set; }
        public virtual ICollection<SegUsuarioRol> SegUsuarioRols { get; set; }
    }
}
