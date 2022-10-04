using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Civy004V
    {
        public decimal? RecordNumber { get; set; }
        public string Producto { get; set; }
        public string OrigenProducto { get; set; }
        public string LineaProducto { get; set; }
        public string FamiliaProduct { get; set; }
        public string TipoProducto { get; set; }
        public decimal? Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public decimal? CantidadXCaja { get; set; }
        public decimal? ExisDiaAnter { get; set; }
        public decimal? ExistActual { get; set; }
        public decimal? Comprometido { get; set; }
        public decimal? ValExisActual { get; set; }
        public decimal? CosPromActual { get; set; }
        public decimal? PreListActual { get; set; }
        public decimal? ExistMaxima { get; set; }
        public decimal? ExistMinima { get; set; }
        public decimal? PtoReorden { get; set; }
        public decimal? ExiInicioMes { get; set; }
        public decimal? ValInicioMes { get; set; }
        public decimal? CostoPromIni { get; set; }
        public decimal? ListInicioMes { get; set; }
        public decimal? ExisFinMes { get; set; }
        public decimal? ValFinMes { get; set; }
        public decimal? CostoPromFin { get; set; }
        public decimal? ListFinMes { get; set; }
        public decimal? SalidaPendien { get; set; }
        public string PrecioSugerido { get; set; }
        public decimal? PorcMarkup { get; set; }
        public string ImpPorConsumo { get; set; }
        public DateTime? FechaUltCompr { get; set; }
        public DateTime? FechaUltFact { get; set; }
        public string FlagObsoleto { get; set; }
        public decimal? UnidadCosteo { get; set; }
        public decimal? CostPromDolar { get; set; }
        public string LineaFamilia { get; set; }
        public decimal? CostoPromReva { get; set; }
        public string TipoPapel { get; set; }
        public string MetodoPrecio { get; set; }
        public decimal? OtroFactor { get; set; }
        public decimal? PorcCosto { get; set; }
        public decimal? Partes { get; set; }
        public string Eliminado { get; set; }
    }
}
