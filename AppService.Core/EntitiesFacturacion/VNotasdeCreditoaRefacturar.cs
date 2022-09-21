using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VNotasdeCreditoaRefacturar
    {
        public int NotaCredito { get; set; }
        public DateTime Fecha { get; set; }
        public int Factura { get; set; }
        public string AfectaFactura { get; set; }
        public decimal Valor { get; set; }
        public int? FacturaRepetir { get; set; }
        public string CodProducto { get; set; }
        public long Orden { get; set; }
        public string NombreCliente { get; set; }
    }
}
