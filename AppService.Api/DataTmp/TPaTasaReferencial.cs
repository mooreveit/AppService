using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class TPaTasaReferencial
    {
        public decimal Id { get; set; }
        public decimal? Tasa { get; set; }
        public DateTime? Fecha { get; set; }
        public string FechaTasa { get; set; }
        public decimal? Rtasa { get; set; }
    }
}
