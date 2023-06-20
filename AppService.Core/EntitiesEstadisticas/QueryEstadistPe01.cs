using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class QueryEstadistPe01
    {
        public decimal? Orden { get; set; }
        public string Producto { get; set; }
        public string NomProducto { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? MillaresP { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public string RegionVta { get; set; }
        public string LineaProduc { get; set; }
        public string NombOfic { get; set; }
        public string Descripcion { get; set; }
        public decimal? ListaDol { get; set; }
        public decimal? VentaDol { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? Concesion { get; set; }
        public string Familia { get; set; }
        public string TituloPe { get; set; }
    }
}
