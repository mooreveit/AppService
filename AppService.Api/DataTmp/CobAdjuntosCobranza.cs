using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobAdjuntosCobranza
    {
        public long IdAdjunto { get; set; }
        public long Documento { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Ruta { get; set; }
        public string TextoPrueba { get; set; }
    }
}
