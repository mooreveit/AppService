using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PccomisionesTemporal
    {
        public decimal Id { get; set; }
        public string IdCliente { get; set; }
        public string Transaccion { get; set; }
        public decimal? Documento { get; set; }
        public short? Linea { get; set; }
        public string TranCancela { get; set; }
        public decimal? DocCancela { get; set; }
        public short? LineaCancela { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string IdVendedor { get; set; }
        public decimal? Monto { get; set; }
        public decimal? PorFactura { get; set; }
        public decimal? Impuesto { get; set; }
        public long? Orden { get; set; }
        public string Producto { get; set; }
        public decimal? MontoReal { get; set; }
        public DateTime? PeriodoDesde { get; set; }
        public DateTime? PeriodoHasta { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public decimal? IdSolicitud { get; set; }
        public decimal? BsComision { get; set; }
        public decimal? BsComisionGrte { get; set; }
        public long? FichaGteProducto { get; set; }
        public decimal? BsComisionGteProducto { get; set; }
        public bool? FlagParcial { get; set; }
        public decimal? RecNumPadre { get; set; }
        public decimal? PorcFlat { get; set; }
        public decimal? ComisionRangoCumplimientoCuotaGeneral { get; set; }
        public decimal? PorcRangoCumplimientoCuotaGeneral { get; set; }
        public decimal? PorcCantidadCuotasCumplidas { get; set; }
        public decimal? ComisionCantidadCuotasCumplidas { get; set; }
        public int? CantidadCuotasCumplidas { get; set; }
        public decimal? TotalVentasMes { get; set; }
        public decimal? TotalCuotaMes { get; set; }
        public int? IdTipoPago { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public decimal? PorcFlatGerente { get; set; }
        public decimal? ComisionRangoCumplimientoCuotaGeneralGerente { get; set; }
        public decimal? PorcRangoCumplimientoCuotaGeneralGerente { get; set; }
        public decimal? PorcCantidadCuotasCumplidasGerente { get; set; }
        public decimal? ComisionCantidadCuotasCumplidasGerente { get; set; }
        public int? CantidadCuotasCumplidasGerente { get; set; }
        public decimal? TotalVentasMesGerente { get; set; }
        public decimal? TotalCuotaMesGerente { get; set; }
        public string IdGerente { get; set; }
        public decimal? BsComisionNuevoReactivado { get; set; }
        public decimal? BsComisionNuevoReactivadoGerente { get; set; }

        public virtual PctipoPago IdTipoPagoNavigation { get; set; }
    }
}
