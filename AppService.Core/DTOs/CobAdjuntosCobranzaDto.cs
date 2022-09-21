using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.DTOs
{
    public class CobAdjuntosCobranzaDto
    {        
        public long Documento { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }

        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string  DescripcionTipoDocumento { get; set; }

        public string Ruta { get; set; }    

        public string Link { get; set; }

        public string Header { get; set; }

        public string Extension { get; set; }

        public string Data { get; set; }

        public bool Valid { get; set; }

        public int Indice { get; set; }

        public bool IsImage { get; set; }

    }
}
