using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class VNotas
    {
        public decimal Recnum { get; set; }
        public int NumeroNota { get; set; }
        public string TipoProducto { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorLista { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Valor { get; set; }
        public decimal ImpSobVentas { get; set; }
        public decimal ImpPorConsumo { get; set; }
        public short TipoDoc { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string LineaProduccio { get; set; }
        public string FamiliaProducc { get; set; }
        public short LineaIncoming { get; set; }
        public DateTime FechaNota { get; set; }
        public string Linea1 { get; set; }
        public string Partes { get; set; }
        public string MetodoPrecio1 { get; set; }
        public string TipoPapel { get; set; }
        public string Familia { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Comision { get; set; }
        public string CtaLista { get; set; }
        public string CtaConc { get; set; }
        public string Estadisticas { get; set; }
        public decimal ValorVentad { get; set; }
        public decimal ValorListad { get; set; }
        public decimal VentaUniDol { get; set; }
        public decimal ListaUniDol { get; set; }
        public decimal ImpuestoDol { get; set; }
        public long? Orden { get; set; }
    }
}
