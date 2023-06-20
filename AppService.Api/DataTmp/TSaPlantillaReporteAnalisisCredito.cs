using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TSaPlantillaReporteAnalisisCredito
    {
        public decimal Id { get; set; }
        public string Idvariables { get; set; }
        public string NombreVariable { get; set; }
        public decimal? LineaReporte { get; set; }
        public string Titulo { get; set; }
        public string IdVariablePadre { get; set; }
    }
}
