using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class GssAdjuntoTarea
    {
        public long IdAdjuntoTarea { get; set; }
        public long IdTarea { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual GssTarea IdTareaNavigation { get; set; }
        public virtual GssTipoDocumento IdTipoDocumentoNavigation { get; set; }
    }
}
