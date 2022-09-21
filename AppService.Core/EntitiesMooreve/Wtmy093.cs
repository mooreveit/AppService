using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wtmy093
    {
        public int Recnum { get; set; }
        public long Orden { get; set; }
        public string NombreCliente { get; set; }
        public string TituloVenta { get; set; }
        public string Titulo1 { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public decimal VentaFacturado { get; set; }
        public decimal VentaPendiente { get; set; }
        public decimal PorcMc { get; set; }
        public string Usuario { get; set; }
        public decimal? BsmcFacturado { get; set; }
        public decimal? BsmcPendiente { get; set; }
        public decimal? RventaFacturado { get; set; }
        public decimal? RventaPendiente { get; set; }
        public decimal? RbsmcFacturado { get; set; }
        public decimal? RbsmcPendiente { get; set; }
    }
}
