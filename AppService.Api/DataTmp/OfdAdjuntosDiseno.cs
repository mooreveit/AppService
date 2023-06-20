using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdAdjuntosDiseno
    {
        public long IdAdjunto { get; set; }
        public long IdSolicitud { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual OfdSolicitudDiseno IdSolicitudNavigation { get; set; }
    }
}
