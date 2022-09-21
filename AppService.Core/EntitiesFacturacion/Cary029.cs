using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Cary029
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
        public string Usuario { get; set; }
        public string Orden { get; set; }
        public string JobId { get; set; }
        public decimal? Copy { get; set; }
        public string Descripcion2 { get; set; }
        public decimal? Millares { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Unidadesfact { get; set; }
        public decimal? Preciounidad { get; set; }
        public string UnidadFacturar { get; set; }
        public decimal? FormasUnidad { get; set; }
        public decimal? Batch { get; set; }
        public string Almacen { get; set; }
        public decimal? PorcMcPapel { get; set; }
        public decimal? PorcMcFinan { get; set; }
        public decimal? PorcMcPapelsc { get; set; }
        public decimal? PorcMcFinansc { get; set; }
        public decimal? BsMcPapel { get; set; }
        public decimal? BsMcFinan { get; set; }
        public decimal? BsMcPapelsc { get; set; }
        public decimal? BsMcFinansc { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? RimpSobVentas { get; set; }
        public decimal? RimpPorConsum { get; set; }
        public decimal? Riva { get; set; }
        public decimal? Rpreciounidad { get; set; }
        public decimal? RprecioVenta { get; set; }
        public string Exento { get; set; }
        public decimal? Ivarefact { get; set; }
        public string TotalparcialFa { get; set; }
        public decimal? Idsolicitud { get; set; }
        public string RecalcularMargen { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? IdSolicitudCosto { get; set; }
        public decimal? Costo { get; set; }
        public decimal? ValorVentaCpj { get; set; }
        public decimal? IdSolicitudCostoCpj { get; set; }
        public decimal? Pieslineales { get; set; }
    }
}
