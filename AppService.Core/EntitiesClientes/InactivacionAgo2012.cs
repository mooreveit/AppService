using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class InactivacionAgo2012
    {
        public double? Cant { get; set; }
        public string CodigoLegacy { get; set; }
        public string CodigoJde { get; set; }
        public string NombreCliente { get; set; }
        public double? CodigoPadre { get; set; }
        public decimal? SaldoCliente { get; set; }
        public string OrdenesEnProceso { get; set; }
        public DateTime? FechaCreación { get; set; }
        public double? MesesCreación { get; set; }
        public DateTime? FechaUltimaCompra { get; set; }
        public double? MesesUltimaCompra { get; set; }
        public string PadreInactivo { get; set; }
        public decimal? SaldoClientePadre { get; set; }
        public string CodigoCobrador { get; set; }
        public string EsPadre { get; set; }
        public double? Hijos { get; set; }
    }
}
