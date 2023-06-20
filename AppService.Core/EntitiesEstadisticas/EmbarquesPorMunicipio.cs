using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class EmbarquesPorMunicipio
    {
        public decimal? AloContable { get; set; }
        public decimal? MesContable { get; set; }
        public string NombreOficina { get; set; }
        public string DescMunicipio { get; set; }
        public decimal? Tipo { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Iva { get; set; }
    }
}
