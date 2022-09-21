using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy605
    {
        public long IdRegistro { get; set; }
        public long IdPrelista { get; set; }
        public short CodigoZona { get; set; }
        public string DescripcionZona { get; set; }
        public long Orden { get; set; }
        public long Job { get; set; }
        public short Copy { get; set; }
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CodigoCliente { get; set; }
        public string RifFacturar { get; set; }
        public string ClienteFacturar { get; set; }
        public decimal IdDireccionEntregar { get; set; }
        public string DireccionEntregar { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int CantidadDespachar { get; set; }
        public int CantidadPorCaja { get; set; }
        public short CantidadCajas { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal BolivaresMc { get; set; }
        public decimal PesoKilos { get; set; }
        public decimal Volumen { get; set; }
        public string EquipoUpdate { get; set; }
        public string UsuarioUpdate { get; set; }
        public DateTime FechaUpdate { get; set; }
        public string FlagFacturada { get; set; }
        public string FlagAgregada { get; set; }
        public string FlagEliminada { get; set; }
        public string EquipoDelete { get; set; }
        public string UsuarioDelete { get; set; }
        public DateTime? FechaDelete { get; set; }
        public string Observaciones { get; set; }
        public int Documento { get; set; }
        public string FlagEnviadoSap { get; set; }
        public decimal? RtotalVenta { get; set; }
        public decimal? RbolivaresMc { get; set; }
    }
}
