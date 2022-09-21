using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCneSeparadores
    {
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public int? IdCentroCapa { get; set; }
        public string CentroCapa { get; set; }
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int IdParroquia { get; set; }
        public string Parroquia { get; set; }
        public int? IdCentroVota { get; set; }
        public string CentroVota { get; set; }
        public int? Caja { get; set; }
        public long? Desde { get; set; }
        public long? Hasta { get; set; }
    }
}
