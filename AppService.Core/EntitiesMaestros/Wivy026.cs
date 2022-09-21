using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMaestros
{
    public partial class Wivy026
    {
        public decimal Recnum { get; set; }
        public int NroIr { get; set; }
        public int Proveedor { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public short FormaPago { get; set; }
        public string NroFactura { get; set; }
        public string NotaEntrega { get; set; }
        public short Mescon { get; set; }
        public string Observacion { get; set; }
        public string TipoAlmacen { get; set; }
        public DateTime? FechaEmision { get; set; }
    }
}
