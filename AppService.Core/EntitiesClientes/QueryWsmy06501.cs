using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesClientes
{
    public partial class QueryWsmy06501
    {
        public decimal? Sector { get; set; }
        public string NombreSector { get; set; }
        public decimal? Ramo { get; set; }
        public string NombreRamo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCambio { get; set; }
    }
}
