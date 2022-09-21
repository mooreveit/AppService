using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Civy004
    {
        public decimal Recnum { get; set; }
        public string Producto { get; set; }
        public string OrigenProducto { get; set; }
        public string LineaProducto { get; set; }
        public string FamiliaProduct { get; set; }
        public string TipoProducto { get; set; }
        public short Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public int CantidadXCaja { get; set; }
        public int ExisDiaAnter { get; set; }
        public int ExistActual { get; set; }
        public int Comprometido { get; set; }
        public decimal ValExisActual { get; set; }
        public decimal CosPromActual { get; set; }
        public decimal PreListActual { get; set; }
        public int ExistMaxima { get; set; }
        public int ExistMinima { get; set; }
        public int PtoReorden { get; set; }
        public int ExiInicioMes { get; set; }
        public decimal ValInicioMes { get; set; }
        public decimal CostoPromIni { get; set; }
        public decimal ListInicioMes { get; set; }
        public int ExisFinMes { get; set; }
        public decimal ValFinMes { get; set; }
        public decimal CostoPromFin { get; set; }
        public decimal ListFinMes { get; set; }
        public int SalidaPendien { get; set; }
        public string PrecioSugerido { get; set; }
        public decimal PorcMarkup { get; set; }
        public string ImpPorConsumo { get; set; }
        public DateTime? FechaUltCompr { get; set; }
        public DateTime? FechaUltFact { get; set; }
        public string FlagObsoleto { get; set; }
        public short UnidadCosteo { get; set; }
        public decimal CostPromDolar { get; set; }
        public decimal CostoPromReva { get; set; }
        public string TipoPapel { get; set; }
        public string MetodoPrecio { get; set; }
        public int OtroFactor { get; set; }
        public decimal PorcCosto { get; set; }
        public short Partes { get; set; }
        public string Eliminado { get; set; }
        public short KilosPorEmpaq { get; set; }
        public long CtdMaximaVta { get; set; }
    }
}
