using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class Factura
    {
        public decimal Recnum { get; set; }
        public string Transaccion { get; set; }
        public int Documento { get; set; }
        public string Tracanc { get; set; }
        public int Docucanc { get; set; }
        public long Orden { get; set; }
        public int Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Producto { get; set; }
        public DateTime FechaFactura { get; set; }
        public short MesContable { get; set; }
        public short AloContable { get; set; }
        public long Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorLista { get; set; }
        public string RegionVta { get; set; }
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public short Oficina { get; set; }
        public short Partes { get; set; }
        public string MetodoPrecio { get; set; }
        public string TipoPapel { get; set; }
        public string TipoProdu { get; set; }
        public string Anulada { get; set; }
        public decimal Impuesto { get; set; }
        public string NombreCliente { get; set; }
        public string Linea1 { get; set; }
        public string Familia { get; set; }
        public short Tipo { get; set; }
        public int MedidaBase { get; set; }
        public int MedidaVariable { get; set; }
        public short MedEnt { get; set; }
        public short MedNum { get; set; }
        public short MedDec { get; set; }
        public decimal TotalKgPapel { get; set; }
        public decimal TotalKgCarbon { get; set; }
        public decimal TotalBsPapel { get; set; }
        public decimal TotalBsCarbon { get; set; }
        public decimal Totalvariable { get; set; }
        public decimal Totalmatotros { get; set; }
        public decimal Bsmc { get; set; }
        public decimal PorcMc { get; set; }
        public decimal Bsmclista { get; set; }
        public decimal ProcMclista { get; set; }
        public decimal Ventadolar { get; set; }
        public string Rif { get; set; }
        public decimal TotalKgSpot { get; set; }
        public decimal TotalBsSpot { get; set; }
        public decimal CostoTt { get; set; }
        public decimal PiesTt { get; set; }
        public decimal BsTt { get; set; }
        public DateTime? FechaOrden { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string DescMunicipio { get; set; }
        public string NombreOficina { get; set; }
        public decimal? Millares { get; set; }
        public decimal? Porciva { get; set; }
        public decimal? Recnumauxiliar { get; set; }
    }
}
