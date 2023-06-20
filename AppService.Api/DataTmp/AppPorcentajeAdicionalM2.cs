using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class AppPorcentajeAdicionalM2
    {
        public int Id { get; set; }
        public decimal M2desde { get; set; }
        public decimal M2hasta { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
