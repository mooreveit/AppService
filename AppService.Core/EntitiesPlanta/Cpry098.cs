using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Cpry098
    {
        public decimal Recnum { get; set; }
        public int NoPedido { get; set; }
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
        public string ColorCarbon { get; set; }
        public short Correlativo { get; set; }
        public long Orden { get; set; }
    }
}
