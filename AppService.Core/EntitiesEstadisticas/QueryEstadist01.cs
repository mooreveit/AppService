using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryEstadist01
    {
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public decimal? Orden { get; set; }
        public decimal? Correlativo { get; set; }
        public decimal? Renglon { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cotizacion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string NombreDeForma { get; set; }
        public string Descripcion { get; set; }
        public string TipoPapel { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Partes { get; set; }
        public string Oficina { get; set; }
        public string NomOficina { get; set; }
        public string Supervisor { get; set; }
        public string GerenteOficina { get; set; }
        public string Region { get; set; }
        public string NombreRegion { get; set; }
        public string GerenteRegion { get; set; }
    }
}
