using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class MunicipioFlete
    {
        public decimal Id { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public decimal? Flete { get; set; }
    }
}
