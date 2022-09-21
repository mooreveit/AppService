using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy698
    {
        public decimal Recnum { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public string IdVendedor { get; set; }
        public int IdCuota { get; set; }
        public decimal BsCuota { get; set; }
        public decimal BsVenta { get; set; }
        public decimal BsVentaNew { get; set; }
        public decimal PorcCobertura { get; set; }
        public decimal PorcCoberturaNew { get; set; }
        public decimal PorcMixPro { get; set; }
        public decimal PorcMixProNew { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCuotaPadre { get; set; }
        public decimal? RbsCuota { get; set; }
        public decimal? RbsVenta { get; set; }
        public decimal? RbsVentaNew { get; set; }
    }
}
