using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Retislr
    {
        public string Transaccion { get; set; }
        public double? Documento { get; set; }
        public double? Linea { get; set; }
        public double? Proveedor { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public double? Fecha { get; set; }
        public string TipoDocRet { get; set; }
        public double? DocRet { get; set; }
        public double? Factura { get; set; }
        public double? Batch { get; set; }
        public double? Monto { get; set; }
        public double? PorcentajeRet { get; set; }
        public string TipodeRet { get; set; }
        public decimal Id { get; set; }
    }
}
