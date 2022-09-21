using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wary252
    {
        public long Id { get; set; }
        public int? Evento { get; set; }
        public DateTime? Fecha { get; set; }
        public string Observacion { get; set; }
        public long? Factura { get; set; }
        public int? Dias { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public string FlagCumplido { get; set; }
        public decimal? Monto { get; set; }
        public long? Cliente { get; set; }
        public string Vendedor { get; set; }
        public int? Reporte { get; set; }
        public int? Oficina { get; set; }
        public string Cancelado { get; set; }
        public string Usuario { get; set; }
        public string Listado { get; set; }
    }
}
