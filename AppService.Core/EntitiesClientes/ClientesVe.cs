using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ClientesVe
    {
        public double? Padre { get; set; }
        public string Nombre { get; set; }
        public double? Codigo { get; set; }
        public string Rif { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }
        public string Ciudad { get; set; }
        public string CP { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Estado1 { get; set; }
        public DateTime? Apertura { get; set; }
        public string Diasdecredito { get; set; }
        public double? Limite { get; set; }
        public string Status { get; set; }
        public DateTime? Modificacion { get; set; }
        public double? Vendedor { get; set; }
        public double? Cobrador { get; set; }
        public double? Supervisor { get; set; }
    }
}
