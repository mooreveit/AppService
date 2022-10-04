using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VFiscalsinnumeracion
    {
        public long Orden { get; set; }
        public string Fiscal { get; set; }
        public DateTime FechaArchivo { get; set; }
        public long? Expr1 { get; set; }
        public string RifImprimir { get; set; }
        public string Sufijo { get; set; }
        public string Prefijo { get; set; }
        public string PrefijoCli { get; set; }
        public string SufijoCli { get; set; }
        public string NumCliDesde { get; set; }
        public string NumCliHasta { get; set; }
        public string NumeroPrefijo { get; set; }
        public string NumeroSubfijo { get; set; }
        public string Web { get; set; }
        public long? CantOrdenada { get; set; }
        public string NombreProducto { get; set; }
        public string DescProducto { get; set; }
        public string Anulada { get; set; }
        public string Cotizacion { get; set; }
        public string CodProducto { get; set; }
    }
}
