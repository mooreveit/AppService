using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class ConversionFactura
    {
        public DateTime FechaFactura { get; set; }
        public int Factura { get; set; }
        public long Orden { get; set; }
        public string Producto { get; set; }
        public string NombreProducto { get; set; }
        public decimal CantidadFact { get; set; }
        public decimal PrecioVentaFact { get; set; }
        public decimal TotalVentaFact { get; set; }
        public decimal? CantidadNueva { get; set; }
        public long? CantidadOrd { get; set; }
        public decimal? PrecioVentaOrd { get; set; }
        public decimal? TotalVentaOrd { get; set; }
    }
}
