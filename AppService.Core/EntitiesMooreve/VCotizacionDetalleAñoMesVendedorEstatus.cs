using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class VCotizacionDetalleAñoMesVendedorEstatus
    {
        public string Cotizacion { get; set; }
        public int Renglon { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string Vendedor { get; set; }
        public string Estatus { get; set; }
        public decimal? TotalPropuesta { get; set; }
        public string SupervisorId { get; set; }
        public string OficinaId { get; set; }
    }
}
