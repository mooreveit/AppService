using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Recuperados
    {
        public decimal Recnum { get; set; }
        public int Factura { get; set; }
        public short CentroFact { get; set; }
        public short TipoDoc { get; set; }
        public string Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorVentad { get; set; }
        public decimal ValorLista { get; set; }
        public decimal ValorListad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioLista { get; set; }
        public long Orden { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public string TipoProducto { get; set; }
        public string FlagImprenta { get; set; }
        public string TotalParcial { get; set; }
        public int NoEntrega { get; set; }
        public long JobId { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string Pais { get; set; }
        public string LineaProduccio { get; set; }
        public string FamiliaProducc { get; set; }
        public string Medida { get; set; }
        public string FlagExistencia { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FecRecPlaneac { get; set; }
        public string FlagTipoJob { get; set; }
        public DateTime? FecComproClte { get; set; }
        public string OrigenProducto { get; set; }
        public string FlagRetenido { get; set; }
        public string Presentacion { get; set; }
        public string FlagTipoOrden { get; set; }
        public int Remision { get; set; }
        public string FlagOficina { get; set; }
        public string Millares { get; set; }
        public string UnidadFact { get; set; }
        public decimal FormasUnidad { get; set; }
        public string PrefijoDesde { get; set; }
        public long NumeroDesde { get; set; }
        public string SufijoDesde { get; set; }
        public string PrefijoHasta { get; set; }
        public long NumeroHasta { get; set; }
        public string SufijoHasta { get; set; }
        public int Bultos { get; set; }
        public decimal ImpuestoDol { get; set; }
        public string Usuario { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Unidadesent { get; set; }
        public decimal? Preciounidad { get; set; }
        public decimal? Copy { get; set; }
    }
}
