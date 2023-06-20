﻿using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class OfdAdjunto
    {
        public OfdAdjunto()
        {
            OfdAdjuntoCriterios = new HashSet<OfdAdjuntoCriterio>();
        }

        public long IdAdjunto { get; set; }
        public short IdTipoDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long? IdAdjuntoCotizadorPluss { get; set; }

        public virtual ICollection<OfdAdjuntoCriterio> OfdAdjuntoCriterios { get; set; }
    }
}
