using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry090
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public DateTime? FechaRenegocia { get; set; }
        public DateTime? FechaOrden { get; set; }
        public decimal ListaUniActua { get; set; }
        public decimal VentaUniActua { get; set; }
        public decimal ListaDolActua { get; set; }
        public decimal VentaDolActua { get; set; }
        public decimal TasaActual { get; set; }
        public long Cantidad { get; set; }
        public decimal TasaRenegocia { get; set; }
        public decimal ListaDolaresR { get; set; }
        public decimal VentaDolaresR { get; set; }
        public decimal ListaUniReneg { get; set; }
        public decimal VentaUniReneg { get; set; }
        public string Oficina { get; set; }
        public DateTime? FechaAjustada { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaFactura { get; set; }
        public short Factura { get; set; }
        public string Ubicacion { get; set; }
        public decimal LtaTotActDol { get; set; }
        public decimal VtaTotActDol { get; set; }
        public decimal LtaTotNueDol { get; set; }
        public decimal VtaTotNueDol { get; set; }
        public decimal LtaTotActBs { get; set; }
        public decimal VtaTotActBs { get; set; }
        public decimal LtaTotNueBs { get; set; }
        public decimal VtaTotNueBs { get; set; }
        public string CodigoProducto { get; set; }
        public string ImpStock { get; set; }
        public string Hora { get; set; }
        public decimal? NuevaCantidad { get; set; }
        public decimal? PorcMcFinan { get; set; }
        public decimal? PorcMcPapel { get; set; }
        public decimal? PorcMcFinansc { get; set; }
        public decimal? PorcMcPapelsc { get; set; }
        public string Nocalculamc { get; set; }
        public decimal? RlistaUniActu { get; set; }
        public decimal? RventaUniActu { get; set; }
        public decimal? RtasaActual { get; set; }
        public decimal? RtasaRenegocia { get; set; }
        public decimal? RlistaUniRene { get; set; }
        public decimal? RventaUniRene { get; set; }
        public string Field44 { get; set; }
        public decimal? RltaTotActBs { get; set; }
        public decimal? RvtaTotActBs { get; set; }
        public decimal? RltaTotNueBs { get; set; }
        public decimal? RvtaTotNueBs { get; set; }
        public DateTime? FechaTasaNueva { get; set; }
        public string Cotizacion { get; set; }
        public int? Renglon { get; set; }
        public int? Propuesta { get; set; }
    }
}
