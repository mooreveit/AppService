using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class EstadisticasEmbarquesLinea
    {
        public decimal Id { get; set; }
        public string Tipo { get; set; }
        public string DescTipo { get; set; }
        public int? IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int? IdSubCategoria { get; set; }
        public string NombreSubCategoria { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public long? Orden { get; set; }
        public decimal? TotalVenta { get; set; }
        public string Cliente { get; set; }
        public int? Documento { get; set; }
        public int? OrdenRpt { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PorMcFinan { get; set; }
        public decimal? PiesCuadrado { get; set; }
        public decimal? TasaDolRef { get; set; }
        public DateTime? FechaDolRef { get; set; }
        public decimal? VentaDolRef { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? McDolRef { get; set; }
        public string Articulo { get; set; }
        public string NombreArticulo { get; set; }
        public string LineaProducto { get; set; }
        public string NombreLinea { get; set; }
        public decimal? TotalKgPapel { get; set; }
        public string Codmos { get; set; }
        public decimal? RtotalVenta { get; set; }
    }
}
