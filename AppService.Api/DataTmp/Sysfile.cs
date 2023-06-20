using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class Sysfile
    {
        public decimal Id { get; set; }
        public string LinkServer { get; set; }
        public string LinkServerProduccion { get; set; }
        public string WebServer { get; set; }
        public string Servidor { get; set; }
        public string MailserverName { get; set; }
        public string MailserverType { get; set; }
        public decimal? MailserverPort { get; set; }
        public short? PrimerDiaSemana { get; set; }
        public string DirVirtualOd { get; set; }
    }
}
