using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy522
    {
        public long Id { get; set; }
        public long? Orden { get; set; }
        public string Transaccion { get; set; }
        public int? CodigoCliente { get; set; }
        public string CodigoProducto { get; set; }
        public long? Factura { get; set; }
        public decimal? MontoDocumento { get; set; }
        public decimal? PorcentajeMc { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public decimal? BolivaresPagado { get; set; }
        public decimal? PorcentajeMcauditado { get; set; }
        public decimal? BolivaresMc { get; set; }
        public decimal? NuevoPorcentajeComision { get; set; }
        public decimal? NuevosBolivaresPagar { get; set; }
        public decimal? DiferenciaPagar { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioRegistra { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioAprueba { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string TransaccionOriginal { get; set; }
        public decimal Documento { get; set; }
        public decimal Linea { get; set; }
        public short? CodigoOficina { get; set; }
        public string CodigoVendedor { get; set; }
        public string PagaCadenaVentas { get; set; }
        public decimal? BolivaresMcanterior { get; set; }
        public decimal? PorcentajeOverrideSupervisor { get; set; }
        public decimal? OverrideSupervisor { get; set; }
        public decimal? NuevoOverrideSupervisor { get; set; }
        public decimal? DiferenciaOverrideSupervisor { get; set; }
        public decimal? PorcentajeOverrideGerenteOficina { get; set; }
        public decimal? OverrideGerenteOficina { get; set; }
        public decimal? NuevoOverrideGerenteOficina { get; set; }
        public decimal? DiferenciaOverrideGerenteOficina { get; set; }
        public decimal? PorcentajeOverrideGerenteRegion { get; set; }
        public decimal? OverrideGerenteRegion { get; set; }
        public decimal? NuevoOverrideGerenteRegion { get; set; }
        public decimal? DiferenciaOverrideGerenteRegion { get; set; }
    }
}
