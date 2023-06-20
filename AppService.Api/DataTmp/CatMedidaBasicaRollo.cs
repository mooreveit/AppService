using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatMedidaBasicaRollo
    {
        public long CatMedidaBasicaRollosId { get; set; }
        public string Medida { get; set; }
        public decimal? MedidaIn { get; set; }
        public decimal? MedidaMm { get; set; }
    }
}
