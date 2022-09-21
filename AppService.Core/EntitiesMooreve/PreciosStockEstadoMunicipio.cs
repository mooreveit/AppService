using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class PreciosStockEstadoMunicipio
    {
        public decimal Id { get; set; }
        public string Producto { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Descripcion { get; set; }
        public string NombreEstado { get; set; }
        public string NombreMunicipio { get; set; }
        public string CapitalMunicipio { get; set; }
        public decimal? PrecioMinimo { get; set; }
        public decimal? PrecioMaximo { get; set; }
        public decimal? IdCalculo { get; set; }
        public decimal? RprecioMinimo { get; set; }
        public decimal? RprecioMaximo { get; set; }
    }
}
