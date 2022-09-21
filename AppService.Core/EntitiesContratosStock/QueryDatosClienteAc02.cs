using System;
using System.Collections.Generic;

namespace AppService.Core.DataContratosStock
{
    public partial class QueryDatosClienteAc02
    {
        public decimal NumCot { get; set; }
        public string CodigoClient { get; set; }
        public string NomCliente { get; set; }
        public string CodVend { get; set; }
        public string Nombre { get; set; }
        public string Oficina { get; set; }
        public string NomOficina { get; set; }
        public DateTime? FecGrab { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
