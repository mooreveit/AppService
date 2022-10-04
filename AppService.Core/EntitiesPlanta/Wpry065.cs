using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry065
    {
        public decimal Recnum { get; set; }
        public string Tipo { get; set; }
        public string Seccion { get; set; }
        public string Cliente { get; set; }
        public string Comentarios { get; set; }
        public long Ficha { get; set; }
        public string Responsable { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Costo { get; set; }
        public long Orden { get; set; }
        public int NroReporte { get; set; }
        public DateTime? FechaEmision { get; set; }
        public int Iq { get; set; }
        public string CodigoProducto { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public short CodCausa { get; set; }
        public string Causa { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string DescProducto { get; set; }
        public DateTime? FechaRodada { get; set; }
        public short Mescon { get; set; }
        public long PiesRodadosP { get; set; }
        public long PiesRodadosC { get; set; }
        public short MesConcurso { get; set; }
        public decimal? Rcosto { get; set; }
    }
}
