using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class SapFacturaNotaEntregaPedidos
    {
        public decimal Id { get; set; }
        public string FacturaSap { get; set; }
        public string FacturaLegacy { get; set; }
        public string EntregaSap { get; set; }
        public string EntregaFiscal { get; set; }
        public string PedidoSap { get; set; }
        public string PedidoLegacy { get; set; }
    }
}
