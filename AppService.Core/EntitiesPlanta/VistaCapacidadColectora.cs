using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VistaCapacidadColectora
    {
        public long Orden { get; set; }
        public long Job { get; set; }
        public short CodigoColectora { get; set; }
        public string NombreColectora { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public int? Anchos { get; set; }
        public decimal? DiasColePlan { get; set; }
        public decimal? DiasColePrel { get; set; }
        public decimal? DiasColeProg { get; set; }
        public decimal? DiasColePrensa { get; set; }
        public decimal? DiasColeColect { get; set; }
        public string TipoOrden { get; set; }
        public string StatusOrden { get; set; }
        public string FlagRetenido { get; set; }
        public decimal? PiesXHora { get; set; }
        public decimal HorasTrabajo { get; set; }
        public short? DiasHistoricos { get; set; }
        public decimal? PiesPlanCole { get; set; }
        public decimal? PiesArteCole { get; set; }
        public decimal? PiesFotoCole { get; set; }
        public decimal? PiesPrensCole { get; set; }
        public decimal? PiesColect { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
