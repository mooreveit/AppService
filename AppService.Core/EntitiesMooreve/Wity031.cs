using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wity031
    {
        public string Base { get; set; }
        public string Tabla { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? RegistrosActualizados { get; set; }
        public string Procedimiento { get; set; }
        public string Ejecutar { get; set; }
        public decimal? Orden { get; set; }
    }
}
