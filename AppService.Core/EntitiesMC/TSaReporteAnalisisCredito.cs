using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaReporteAnalisisCredito
    {
        public decimal Id { get; set; }
        public decimal? IdSolicitud { get; set; }
        public string Idvariables { get; set; }
        public string NombreVariable { get; set; }
        public string Valor { get; set; }
        public decimal? LineaReporte { get; set; }
        public string Titulo { get; set; }
        public string Cotizacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string IdvariablePadre { get; set; }
    }
}
