using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Wpry094
    {
        public decimal Recnum { get; set; }
        public long Orden { get; set; }
        public short Parte { get; set; }
        public string Cliente { get; set; }
        public short CtdTintasFte { get; set; }
        public string Frente1 { get; set; }
        public string Frente2 { get; set; }
        public string Frente3 { get; set; }
        public string Frente4 { get; set; }
        public string Frente5 { get; set; }
        public string Frente6 { get; set; }
        public short CtdTintasResp { get; set; }
        public string Resp1 { get; set; }
        public string Resp2 { get; set; }
        public string Resp3 { get; set; }
        public string Resp4 { get; set; }
        public string Resp5 { get; set; }
        public string Resp6 { get; set; }
        public decimal Lista { get; set; }
        public decimal Venta { get; set; }
        public string CodigoPapel { get; set; }
        public string MetodoPrecio { get; set; }
        public string TipoPapel { get; set; }
        public long Formas { get; set; }
        public string AnchosRodados { get; set; }
        public long FormasXRollo { get; set; }
        public string CodigoProducto { get; set; }
        public short CtdPerfH { get; set; }
        public short CtdPerfV { get; set; }
        public string Linea { get; set; }
        public DateTime? FechaOrden { get; set; }
        public DateTime? FechaArchDesd { get; set; }
        public DateTime? FechaArchHast { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public string CarbonSpot { get; set; }
        public decimal Concesion { get; set; }
        public decimal? Rlista { get; set; }
        public decimal? Rventa { get; set; }
    }
}
