using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class TbRptstk02
    {
        public decimal Id { get; set; }
        public string CodProducto { get; set; }
        public string DescProducto { get; set; }
        public DateTime? FechaProg { get; set; }
        public decimal? Programado { get; set; }
        public decimal? Pendiente { get; set; }
        public int? CantidadXCaja { get; set; }
        public decimal? ExistActual { get; set; }
        public int? CajasProgramadas { get; set; }
        public long? Orden { get; set; }
        public string Nombre { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? TotVenta { get; set; }
        public decimal? PorcMcFinan { get; set; }
        public decimal? BsMcFinan { get; set; }
    }
}
