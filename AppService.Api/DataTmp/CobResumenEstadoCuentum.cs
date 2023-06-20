using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CobResumenEstadoCuentum
    {
        public decimal Id { get; set; }
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
        public int? Oficina { get; set; }
        public string NombreOficina { get; set; }
        public string Consultor { get; set; }
        public string NombreConsultor { get; set; }
        public decimal Saldo { get; set; }
        public int? CodigoRango { get; set; }
        public string DescripcionRango { get; set; }
    }
}
