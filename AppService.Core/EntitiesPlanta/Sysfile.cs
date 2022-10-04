using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Sysfile
    {
        public decimal Recnum { get; set; }
        public string CompanyName { get; set; }
        public DateTime? Date { get; set; }
        public short LargoPagina { get; set; }
        public short SaltoPagina { get; set; }
        public short Pais { get; set; }
        public int NoDeEntrega { get; set; }
        public long JobIdActual { get; set; }
        public int NoComprobante { get; set; }
        public string Proceso { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public short Correlativo { get; set; }
        public long OrdInicial { get; set; }
        public long UltOrden { get; set; }
        public long NoReopActual { get; set; }
        public int NoAnulacActua { get; set; }
        public short PrensaDefault { get; set; }
        public short ColectDefault { get; set; }
        public short DiasCriteInac { get; set; }
        public short DiasFulfilment { get; set; }
        public int ConsArchivo { get; set; }
        public decimal PorcPrensaMcp { get; set; }
        public decimal PorcPrensaOpa { get; set; }
        public decimal PorcColectMcp { get; set; }
        public decimal PorcColectOpa { get; set; }
        public decimal? UltimoCep { get; set; }
    }
}
