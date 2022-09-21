using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Req015
    {
        public long Id { get; set; }
        public long IdAdjunto { get; set; }
        public long IdRequerimiento { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaServidor { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime FechaArchivo { get; set; }
    }
}
