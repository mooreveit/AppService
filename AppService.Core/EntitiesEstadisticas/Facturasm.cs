using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Facturasm
    {
        public int? RecordNumber { get; set; }
        public string Transaccion { get; set; }
        public decimal? Documento { get; set; }
        public string Tracanc { get; set; }
        public decimal? Docucanc { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Producto { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public string RegionVta { get; set; }
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public decimal? Oficina { get; set; }
        public decimal? Partes { get; set; }
        public string MetodoPrecio { get; set; }
        public string TipoPapel { get; set; }
        public string TipoProdu { get; set; }
        public string Anulada { get; set; }
        public decimal? Impuesto { get; set; }
        public string NombreCliente { get; set; }
        public string Linea1 { get; set; }
        public string Familia { get; set; }
        public decimal? Tipo { get; set; }
        public decimal? MedidaBase { get; set; }
        public decimal? MedidaVariable { get; set; }
        public decimal? MedEnt { get; set; }
        public decimal? MedNum { get; set; }
        public decimal? MedDec { get; set; }
        public decimal? TotalKgPapel { get; set; }
        public decimal? TotalKgCarbon { get; set; }
        public decimal? TotalBsPapel { get; set; }
        public decimal? TotalBsCarbon { get; set; }
        public decimal? Totalvariable { get; set; }
        public decimal? Totalmatotros { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? Bsmclista { get; set; }
        public decimal? ProcMclista { get; set; }
        public decimal? Ventadolar { get; set; }
        public string Rif { get; set; }
        public decimal? TotalKgSpot { get; set; }
        public decimal? TotalBsSpot { get; set; }
        public decimal? CostoTt { get; set; }
        public decimal? PiesTt { get; set; }
        public decimal? BsTt { get; set; }
        public decimal? Millares { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string DescMunicipio { get; set; }
        public string NombreOficina { get; set; }
        public decimal? Conteo { get; set; }
        public DateTime? FechaOrden { get; set; }
        public decimal? Recnumauxiliar { get; set; }
    }
}
