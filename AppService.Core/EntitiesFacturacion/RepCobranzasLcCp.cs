using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class RepCobranzasLcCp
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Inactivo { get; set; }
        public string TipoNegocio { get; set; }
        public string NombreTipo { get; set; }
        public string ZonaCobranza { get; set; }
        public string NombreZc { get; set; }
        public decimal UnidaTributariaBs { get; set; }
        public decimal? LcMinimoUt { get; set; }
        public decimal? LcMinimoBs { get; set; }
        public decimal? LcPromedioUt { get; set; }
        public decimal? LcPromedioBs { get; set; }
        public decimal? LcMaximoUt { get; set; }
        public decimal? LcMaximoBs { get; set; }
        public decimal? CpMinima { get; set; }
        public string DescripcionCpMin { get; set; }
        public decimal? CpPromedio { get; set; }
        public string DescripcionCpProm { get; set; }
        public decimal? CpMaxima { get; set; }
        public string DescripcionCpMax { get; set; }
    }
}
