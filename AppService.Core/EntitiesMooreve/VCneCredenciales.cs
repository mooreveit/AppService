using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCneCredenciales
    {
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public int IdCentroCapacitacion { get; set; }
        public string CentroCapacitacion { get; set; }
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int IdParroquia { get; set; }
        public string Parroquia { get; set; }
        public int? IdCentroVotacion { get; set; }
        public string CentroVotacion { get; set; }
        public int? Caja { get; set; }
        public int? Cedula { get; set; }
        public string MensajeCentroCapa { get; set; }
    }
}
