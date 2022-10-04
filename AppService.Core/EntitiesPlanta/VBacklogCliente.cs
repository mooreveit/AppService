using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class VBacklogCliente
    {
        public int Cliente { get; set; }
        public long Orden { get; set; }
        public long JobId { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal? PorFacturar { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
