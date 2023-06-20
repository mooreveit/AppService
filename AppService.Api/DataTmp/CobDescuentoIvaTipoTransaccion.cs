using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobDescuentoIvaTipoTransaccion
    {
        public short Id { get; set; }
        public string IdTipoTransaccion { get; set; }
        public decimal BsDesde { get; set; }
        public decimal BsHasta { get; set; }
        public decimal PorcDescuento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal? RbsDesde { get; set; }
        public decimal? RbsHasta { get; set; }
    }
}
