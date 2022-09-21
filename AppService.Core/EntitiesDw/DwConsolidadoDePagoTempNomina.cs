using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwConsolidadoDePagoTempNomina
    {
        public string Cia { get; set; }
        public string Auxiliar { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Transaccion { get; set; }
        public string Descripcion { get; set; }
        public int? Documento { get; set; }
        public string TraCanc { get; set; }
        public int? DocCanc { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? Monto { get; set; }
        public string An8 { get; set; }
        public string NombreAn8 { get; set; }
        public string Cuenta { get; set; }
        public int? Signo { get; set; }
        public string Articulo { get; set; }
        public decimal? CtoCodcto { get; set; }
        public string TnomTipnom { get; set; }
    }
}
