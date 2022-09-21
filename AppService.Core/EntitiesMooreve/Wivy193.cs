using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wivy193
    {
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public decimal? DiasHablies { get; set; }
        public decimal Requisicion { get; set; }
        public DateTime? FechaRequisicion { get; set; }
        public decimal? OrdenCompra { get; set; }
        public DateTime? FechaOrdenCompra { get; set; }
        public decimal? DiasTranscurridos { get; set; }
        public string Comprador { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaRecibidaPlanta { get; set; }
        public string Moneda { get; set; }
    }
}
