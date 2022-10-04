using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wtmy226
    {
        public string OrdenPlanta { get; set; }
        public string Orden { get; set; }
        public string NomProveedor { get; set; }
        public string CodProveedor { get; set; }
        public string DescEstacion { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaTerminada { get; set; }
        public DateTime? FechaEstimada { get; set; }
        public DateTime? FechaProg { get; set; }
        public decimal? CantidadProg { get; set; }
        public string CodProduc { get; set; }
        public decimal? DiasRetrazo { get; set; }
        public decimal? DiasEntregaTerminada { get; set; }
        public decimal? CodEstacion { get; set; }
        public string Status { get; set; }
    }
}
