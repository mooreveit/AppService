using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry014a
    {
        public decimal? Orden { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estacion { get; set; }
        public string Usuario { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public string UsuarioReporte { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
    }
}
