using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class MtrClienteProspecto
    {
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Rif { get; set; }
        public string IdVendedor { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
