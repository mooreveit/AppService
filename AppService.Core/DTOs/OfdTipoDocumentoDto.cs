using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class OfdTipoDocumentoDto
    {

        public short IdTipoDocumento { get; set; }
        public short IdGrupoTipoDocumento { get; set; }
        public string NombreDocumento { get; set; }
        public bool Obligatorio { get; set; }
        public bool AfectaExpediente { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
