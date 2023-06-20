using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class ResumenDeVentasDelMe
    {
        public int? RecordNumber { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Correlativo { get; set; }
        public decimal? Renglon { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
        public string Tipo { get; set; }
        public decimal? Clase { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public string Supervisor { get; set; }
        public string TipoVend { get; set; }
        public string Grupo { get; set; }
        public string Cotizacion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Mes { get; set; }
        public decimal? Partes { get; set; }
        public decimal? MillaresP { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public string ZonaVta { get; set; }
        public string RegionVta { get; set; }
        public string TipoPapel { get; set; }
        public string MetodoLista { get; set; }
        public string TipoProdu { get; set; }
        public string Territorio { get; set; }
        public decimal? NotaCambio { get; set; }
        public decimal? Formas { get; set; }
        public string Basica { get; set; }
        public string Opuesta { get; set; }
        public decimal? Conteo { get; set; }
        public string Codmos { get; set; }
        public string Fiscal { get; set; }
        public string CodPro { get; set; }
        public string CodproRpg { get; set; }
        public string Flag { get; set; }
        public string Codcorp { get; set; }
        public decimal? MesReorden { get; set; }
        public decimal? AnoReorden { get; set; }
        public string LineaProduc { get; set; }
        public string NombOfic { get; set; }
        public string Region { get; set; }
    }
}
