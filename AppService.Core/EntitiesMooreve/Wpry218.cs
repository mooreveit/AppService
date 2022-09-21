using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry218
    {
        public int Id { get; set; }
        public int IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public string Abreviado { get; set; }
        public int? IdSoporte { get; set; }
        public bool? SwConsultas { get; set; }
        public string Aprobada { get; set; }
        public string Rechazada { get; set; }
        public string Tct { get; set; }
        public string Tcttitulo { get; set; }
        public string Tctestatus { get; set; }
    }
}
