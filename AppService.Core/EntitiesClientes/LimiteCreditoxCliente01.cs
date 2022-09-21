using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class LimiteCreditoxCliente01
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? LimiteCredUt { get; set; }
        public decimal UtBs { get; set; }
        public decimal? TotalBs { get; set; }
        public string TipoNegocio { get; set; }
        public string AreaCobranz { get; set; }
        public string NombZona { get; set; }
    }
}
