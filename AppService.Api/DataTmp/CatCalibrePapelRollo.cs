using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CatCalibrePapelRollo
    {
        public long CatCalibrePapelRollosId { get; set; }
        public string Papel { get; set; }
        public int? Gramaje { get; set; }
        public decimal? Calibre { get; set; }
    }
}
