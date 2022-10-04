using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VistaResumenCp
    {
        public long Orden { get; set; }
        public long Job { get; set; }
        public short NoPrensa { get; set; }
        public short NoColectora { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public int? Anchos { get; set; }
        public string Doblado { get; set; }
        public decimal? PiesPlanPren { get; set; }
        public decimal? PiesPlanCole { get; set; }
        public decimal? PiesArtePren { get; set; }
        public decimal? PiesArteCole { get; set; }
        public decimal? PiesFotoPren { get; set; }
        public decimal? PiesFotoCole { get; set; }
        public decimal? PiesPrensPren { get; set; }
        public decimal? PiesPrensCole { get; set; }
        public decimal? PiesColect { get; set; }
        public decimal HorasTrabajo { get; set; }
        public string TipoOrden { get; set; }
        public string StatusOrden { get; set; }
        public string FlagRetenido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal? Venta { get; set; }
    }
}
