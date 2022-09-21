using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy560
    {
        public long Id { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaServidor { get; set; }
        public string RutaArchivo { get; set; }
        public DateTime FechaArchivo { get; set; }
        public string FlagInactivo { get; set; }
    }
}
