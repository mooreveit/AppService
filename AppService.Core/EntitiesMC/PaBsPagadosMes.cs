using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class PaBsPagadosMes
    {
        public decimal Id { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public decimal? BsPagadoMes { get; set; }
    }
}
