using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wpry247
    {
        public int IdMedida { get; set; }
        public decimal MedidaDecimal { get; set; }
        public string MedidaMascara { get; set; }
        public string MedidaFraccion { get; set; }
        public int IdTipoMedida { get; set; }
    }
}
