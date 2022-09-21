using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMC
{
    public partial class TSaEstadisticaPapelEmbarques
    {
        public decimal Id { get; set; }
        public int LineaNegocio { get; set; }
        public string IdVariables { get; set; }
        public decimal IdSolicitud { get; set; }
        public int Item { get; set; }
        public decimal? Año { get; set; }
        public decimal? Mes { get; set; }
        public decimal? AñoMes { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Factura { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public string Genero { get; set; }
        public string DescripcionGenero { get; set; }
        public string Articulo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Papel { get; set; }
        public decimal? Kg { get; set; }
        public decimal? Venta { get; set; }
        public decimal? TotalKg { get; set; }
        public decimal? BsKg { get; set; }
        public decimal? CostoPapel { get; set; }
        public decimal? TotalCosto { get; set; }
        public string Origen { get; set; }
    }
}
