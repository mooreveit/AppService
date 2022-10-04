using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Csmy021
    {
        public decimal Recnum { get; set; }
        public string Cotizacion { get; set; }
        public short Parte { get; set; }
        public short NoPartePapel { get; set; }
        public short ClasePapel { get; set; }
        public int MedidaPapel { get; set; }
        public short PesoPapel { get; set; }
        public short ColorPapel { get; set; }
        public string PrimTintaFte { get; set; }
        public string CondPrimTinta { get; set; }
        public string SegTintaFrent { get; set; }
        public string CondSegTinta { get; set; }
        public string TercTintaFren { get; set; }
        public string CondTercTinta { get; set; }
        public string CuarTintaFren { get; set; }
        public string CondCuarTinta { get; set; }
        public string QuinTintaFren { get; set; }
        public string CondQuinTinta { get; set; }
        public string SexTintaFren { get; set; }
        public string CondSexTinta { get; set; }
        public string PrimTintaResp { get; set; }
        public string ConPrimTintar { get; set; }
        public string SegTintaResp { get; set; }
        public string CondSegTintar { get; set; }
        public string TercTintaResp { get; set; }
        public string CondTerTintar { get; set; }
        public string PerfHorizontal { get; set; }
        public string PerfVertical { get; set; }
        public string MedTalonIzq { get; set; }
        public string MedTalonDer { get; set; }
        public string PosTalon { get; set; }
        public string ColorCarbon { get; set; }
        public long Orden { get; set; }
        public short Correlativo { get; set; }
        public string MedidaCarbon { get; set; }
        public string CodCarbon { get; set; }
        public string CodPapel { get; set; }
        public string CarbSpot { get; set; }
        public decimal Medcarbonent { get; set; }
        public string CuarTintaResp { get; set; }
        public string QuinTintaResp { get; set; }
        public string SexTintaResp { get; set; }
        public string Prueba { get; set; }
        public decimal KilosPapel { get; set; }
        public decimal KilosCarbon { get; set; }
        public int MedidaMatPap { get; set; }
        public decimal MedMatPapDec { get; set; }
        public int TalonExtra { get; set; }
        public decimal? PrecioPapel { get; set; }
        public decimal? RprecioPapel { get; set; }
        public string FraseMarginal { get; set; }
    }
}
