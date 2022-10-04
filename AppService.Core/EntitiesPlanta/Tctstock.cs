using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Tctstock
    {
        public decimal? Orden { get; set; }
        public string Cliente { get; set; }
        public DateTime? Prometida { get; set; }
        public DateTime? Tomada { get; set; }
        public DateTime? Grabada { get; set; }
        public DateTime? FechaAprobAdm { get; set; }
        public decimal? DiasAdministradora { get; set; }
        public decimal? DiasVentas { get; set; }
        public DateTime? AprobCobranza { get; set; }
        public decimal? DiasCobranza { get; set; }
        public DateTime? AprobPlanta { get; set; }
        public decimal? DiasPlanta { get; set; }
        public DateTime? Factura { get; set; }
        public decimal? DiasFactura { get; set; }
        public DateTime? SalidaCamion { get; set; }
        public decimal? DiasParaEmbarcar { get; set; }
        public DateTime? Entrega { get; set; }
        public decimal? DiasDespacho { get; set; }
        public decimal? CodOficina { get; set; }
        public string Oficina { get; set; }
        public string CodRegion { get; set; }
        public string Region { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int? CodZona { get; set; }
        public string ZonaDespacho { get; set; }
        public string Web { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string StatusOrden { get; set; }
        public string Producto { get; set; }
        public string TipoProducto { get; set; }
        public decimal? DiasProd { get; set; }
        public decimal? DiasMoore { get; set; }
        public decimal? DiasAtraso { get; set; }
        public int? ContAtraso { get; set; }
        public decimal? RecordNumber { get; set; }
        public string CodCliente { get; set; }
        public decimal? CodResponsable { get; set; }
        public DateTime? FechaEntradaCxc { get; set; }
        public DateTime? FechaSalidaCxc { get; set; }
        public int? DiasCxc { get; set; }
    }
}
