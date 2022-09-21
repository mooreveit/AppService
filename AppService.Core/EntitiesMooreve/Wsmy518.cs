using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy518
    {
        public short IdOficina { get; set; }
        public short Ano { get; set; }
        public short Mes { get; set; }
        public string NombreOficina { get; set; }
        public decimal? VentasMesDolar { get; set; }
        public decimal? VentasMesBolivar { get; set; }
        public decimal? CuotaMes { get; set; }
        public decimal? PorcCuotaMes { get; set; }
        public short? DsoMes { get; set; }
        public decimal? VentasYtddolar { get; set; }
        public decimal? VentasYtdbolivar { get; set; }
        public decimal? CuotaYtd { get; set; }
        public decimal? PorcCuotaYtd { get; set; }
        public short? DsoYtd { get; set; }
        public long? TotalOrdenesMes { get; set; }
        public long? TotalOrdenesAno { get; set; }
        public decimal? PorcMcMes { get; set; }
        public decimal? PorcMcAno { get; set; }
        public decimal? PuntoCoverCuota { get; set; }
        public decimal? PuntoAddCuota { get; set; }
        public decimal? PuntoDso { get; set; }
        public decimal? PuntoMc { get; set; }
        public decimal? PuntoAddMc { get; set; }
        public decimal? BsMcMes { get; set; }
        public decimal? BsMcAno { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? RventasMesBolivar { get; set; }
        public decimal? RcuotaMes { get; set; }
        public decimal? RbsMcMes { get; set; }
        public decimal? RbsMcAno { get; set; }
    }
}
