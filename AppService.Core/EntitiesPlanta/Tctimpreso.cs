using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesPlanta
{
    public partial class Tctimpreso
    {
        public decimal? Orden { get; set; }
        public decimal? Job { get; set; }
        public string Cliente { get; set; }
        public DateTime? Prometida { get; set; }
        public DateTime? Tomada { get; set; }
        public DateTime? Archivo { get; set; }
        public decimal? DiasVentas { get; set; }
        public DateTime? Planeacion { get; set; }
        public decimal? DiasRetPlan { get; set; }
        public decimal? DiasPlan { get; set; }
        public DateTime? Preliminares { get; set; }
        public decimal? DiasRetPrel { get; set; }
        public decimal? DiasPrel { get; set; }
        public int? ContPrel { get; set; }
        public DateTime? Programacion { get; set; }
        public decimal? DiasRetProg { get; set; }
        public DateTime? Prensas { get; set; }
        public decimal? DiasRetPren { get; set; }
        public decimal? DiasPrensas { get; set; }
        public int? ContPren { get; set; }
        public DateTime? Colectora { get; set; }
        public decimal? DiasRetColec { get; set; }
        public decimal? DiasColectora { get; set; }
        public int? ContCole { get; set; }
        public DateTime? Acabado { get; set; }
        public decimal? DiasRetAca { get; set; }
        public decimal? DiasAcabado { get; set; }
        public int? ContAcab { get; set; }
        public DateTime? Factura { get; set; }
        public decimal? DiasRetEmb { get; set; }
        public decimal? DiasFactura { get; set; }
        public DateTime? SalidaCamion { get; set; }
        public decimal? DiasParaEmbarcar { get; set; }
        public DateTime? Entrega { get; set; }
        public decimal? DiasDespacho { get; set; }
        public decimal? CodOficina { get; set; }
        public string Oficina { get; set; }
        public string Linea { get; set; }
        public string Familia { get; set; }
        public string LineaFamilia { get; set; }
        public string DescripcionLinea { get; set; }
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
        public decimal? DiasProd { get; set; }
        public decimal? DiasMoore { get; set; }
        public decimal? DiasAtraso { get; set; }
        public decimal? DiasManufactura { get; set; }
        public decimal? DiasLogistica { get; set; }
        public int? ContAtraso { get; set; }
        public string StatusOrden { get; set; }
        public decimal? RecordNumber { get; set; }
        public string CodCliente { get; set; }
        public decimal? CodResponsable { get; set; }
        public DateTime? FechaRecibida { get; set; }
        public DateTime? FechaEntradaCxc { get; set; }
        public DateTime? FechaSalidaCxc { get; set; }
        public int? DiasCxc { get; set; }
    }
}
