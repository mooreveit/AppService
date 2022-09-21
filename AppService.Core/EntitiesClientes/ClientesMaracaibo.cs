using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class ClientesMaracaibo
    {
        public decimal? Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Region { get; set; }
        public string Vendedor { get; set; }
        public string Ciudad { get; set; }
    }
}
