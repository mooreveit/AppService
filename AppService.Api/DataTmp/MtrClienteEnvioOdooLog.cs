using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrClienteEnvioOdooLog
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public string JsonSend { get; set; }
        public string Mensaje { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
