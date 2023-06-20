using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Diascalle
    {
        public decimal? Cia { get; set; }
        public string NombreCia { get; set; }
        public decimal? Region { get; set; }
        public string NombreRegion { get; set; }
        public decimal? Oficina { get; set; }
        public string NombreOficina { get; set; }
        public string Supervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public decimal? Dias { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Mes { get; set; }
    }
}
