using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwConsolidadoDePago
    {
        public decimal Id { get; set; }
        public string Cia { get; set; }
        public string Auxiliar { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public string Transaccion { get; set; }
        public double? Documento { get; set; }
        public string TraCanc { get; set; }
        public string DocCanc { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEmisionDocCanc { get; set; }
        public DateTime? FechaVencDocCanc { get; set; }
        public decimal? Monto { get; set; }
        public double? An8 { get; set; }
        public string NombreAn8 { get; set; }
        public string NombreCuentaContable { get; set; }
        public double? Signo { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal? CtoCodcto { get; set; }
        public string TnomTipnom { get; set; }
    }
}
