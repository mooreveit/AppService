using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VistaCapacidadPrensa
    {
        public long Orden { get; set; }
        public long Job { get; set; }
        public short CodigoPrensa { get; set; }
        public string NombrePrensa { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public int? Anchos { get; set; }
        public string Doblado { get; set; }
        public decimal DiasPrenPlan { get; set; }
        public decimal DiasPrenPrel { get; set; }
        public decimal DiasPrenProg { get; set; }
        public decimal DiasPrenPrensa { get; set; }
        public string TipoOrden { get; set; }
        public string StatusOrden { get; set; }
        public string FlagRetenido { get; set; }
        public decimal? PiesXHora { get; set; }
        public decimal HorasTrabajo { get; set; }
        public short? DiasHistoricos { get; set; }
        public decimal? PiesPlanPren { get; set; }
        public decimal? PiesArtePren { get; set; }
        public decimal? PiesFotoPren { get; set; }
        public decimal? PiesPrensPren { get; set; }
        public decimal? VentaXHora { get; set; }
        public decimal? Venta { get; set; }
        public decimal? DiasTotVenta { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
