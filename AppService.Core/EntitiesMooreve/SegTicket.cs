using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class SegTicket
    {
        public decimal Id { get; set; }
        public string TicketSha1 { get; set; }
        public bool FlagUsado { get; set; }
        public string IdUsuario { get; set; }
        public string IpUsuario { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraUso { get; set; }
        public DateTime? FechaHoraGetIp { get; set; }
    }
}
