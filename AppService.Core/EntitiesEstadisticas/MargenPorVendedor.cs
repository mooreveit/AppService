using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class MargenPorVendedor
    {
        public string Vendedor { get; set; }
        public string Producto { get; set; }
        public decimal? Ano { get; set; }
        public decimal? Venta { get; set; }
        public decimal? Lista { get; set; }
        public string Tipo { get; set; }
        public string TipoPapel { get; set; }
        public string Metodo { get; set; }
        public decimal? Bsmc { get; set; }
        public decimal? PorcMc { get; set; }
        public decimal? Tabla { get; set; }
        public decimal? PorcComision { get; set; }
        public decimal? Comision { get; set; }
        public decimal? PorcOverride { get; set; }
        public decimal? Override { get; set; }
        public decimal? PorcOverger { get; set; }
        public decimal? Concesion { get; set; }
        public decimal? Overger { get; set; }
        public string NombreRegion { get; set; }
        public string NombreOficina { get; set; }
        public string NombreVend { get; set; }
        public string Ficha { get; set; }
    }
}
