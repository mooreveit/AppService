using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry035
    {
        public decimal Recnum { get; set; }
        public short Codigo { get; set; }
        public short Familia { get; set; }
        public string Descripcion { get; set; }
        public string Localiz { get; set; }
        public int ExistActual { get; set; }
        public int ExistMaxima { get; set; }
        public int ExistMinima { get; set; }
        public int Reorden { get; set; }
        public int ConsSemesUnid { get; set; }
        public decimal ConsSemesValo { get; set; }
        public int UltCompraUnid { get; set; }
        public int UltCompraCost { get; set; }
        public DateTime? UltCompraFech { get; set; }
        public int ExiIniMesUni { get; set; }
        public decimal ExiIniMesVal { get; set; }
        public int EntradMesUnid { get; set; }
        public decimal EntradMesVal { get; set; }
        public int SalidMesUnida { get; set; }
        public decimal SalidMesValor { get; set; }
        public int ExiFinMesUni { get; set; }
        public decimal ExiFinMesVal { get; set; }
        public int CantidadReserv { get; set; }
    }
}
