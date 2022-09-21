using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VCuadreFa
    {
        public int Factura { get; set; }
        public string Articulo { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorLista { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Linea1 { get; set; }
        public string Partes { get; set; }
        public string MetodoPrecio1 { get; set; }
        public string TipoPapel { get; set; }
        public string CtaLista { get; set; }
        public string CtaConc { get; set; }
    }
}
