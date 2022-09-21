using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy458
    {
        public int Recnum { get; set; }
        public string DescripRango { get; set; }
        public int Año { get; set; }
        public int? TotalClientes { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? PorCliente { get; set; }
        public decimal? PorVenta { get; set; }
        public int? OrdenImp { get; set; }
        public int Mes { get; set; }
        public decimal? RTotalVenta { get; set; }
        public int? TotalCliAct { get; set; }
        public int? TotalCliAnt { get; set; }
        public decimal? TotalVentAct { get; set; }
        public decimal? TotalVentAnt { get; set; }
        public decimal? TotalVentActDol { get; set; }
        public decimal? TotalVentAntDol { get; set; }
    }
}
