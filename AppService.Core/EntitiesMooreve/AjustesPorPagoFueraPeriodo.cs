using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class AjustesPorPagoFueraPeriodo
    {
        public decimal Id { get; set; }
        public string Cotizacion { get; set; }
        public int? Renglon { get; set; }
        public int? Propuesta { get; set; }
        public long? Orden { get; set; }
        public string Producto { get; set; }
        public bool? FijarPreciosBs { get; set; }
        public DateTime? FechaPago { get; set; }
        public int? AñoPago { get; set; }
        public int? MesPago { get; set; }
        public int? AñoOrden { get; set; }
        public int? MesOrden { get; set; }
        public decimal? TotalBsActual { get; set; }
        public decimal? UnitarioBsActual { get; set; }
        public decimal? TotalBsNuevo { get; set; }
        public decimal? UnitarioBsNuevo { get; set; }
        public decimal? TotalUsdActual { get; set; }
        public decimal? UnitarioUsdActual { get; set; }
        public decimal? TotalUsdNuevo { get; set; }
        public decimal? UnitarioUsdNuevo { get; set; }
        public decimal? TasaActual { get; set; }
        public DateTime? FechaTasaActual { get; set; }
        public decimal? TasaNueva { get; set; }
        public DateTime? FechaTasaNueva { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string Oficina { get; set; }
        public long? Cantidad { get; set; }
        public string ImpStock { get; set; }
        public decimal? RtotalBsActual { get; set; }
        public decimal? RunitarioBsActual { get; set; }
        public decimal? RtotalBsNuevo { get; set; }
        public decimal? RunitarioBsNuevo { get; set; }
        public decimal? RtasaActual { get; set; }
        public decimal? RtasaNueva { get; set; }
    }
}
