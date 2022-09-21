using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesFacturacion
{
    public partial class Sysfile
    {
        public decimal Recnum { get; set; }
        public string CompanyName { get; set; }
        public DateTime? Date { get; set; }
        public short LargoPagina { get; set; }
        public short SaltoPagina { get; set; }
        public short Pais { get; set; }
        public decimal CtaImpSVenta { get; set; }
        public int ComprobanteFac { get; set; }
        public DateTime? FechaCompFac { get; set; }
        public short OficinaDefecto { get; set; }
        public string CifrasGen { get; set; }
        public string CifrasEti { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public decimal? Batch { get; set; }
        public decimal NroControl { get; set; }
        public string ActMiscelaneo { get; set; }
    }
}
