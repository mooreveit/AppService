using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class CrmTicketEncuesta
    {
        public decimal IdEncuesta { get; set; }
        public string IdCliente { get; set; }
        public string TicketSha1 { get; set; }
        public DateTime Fecha { get; set; }
        public bool FlagContestada { get; set; }
        public DateTime? FechaContestada { get; set; }
    }
}
