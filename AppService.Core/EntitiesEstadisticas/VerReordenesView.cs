using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VerReordenesView
    {
        public decimal? Orden { get; set; }
        public decimal? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Vendedor { get; set; }
        public string NomVendedor { get; set; }
        public string Supervisor { get; set; }
        public string NomSupervisor { get; set; }
        public string GerenteRegion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string NombreDeForma { get; set; }
        public string Descripcion { get; set; }
        public decimal? ValorLista { get; set; }
        public decimal? ValorVenta { get; set; }
        public string RegionVta { get; set; }
        public string TipoPapel { get; set; }
        public decimal? Formas { get; set; }
        public decimal? MesReorden { get; set; }
        public decimal? AnoReorden { get; set; }
        public DateTime? FechaReorden { get; set; }
        public string NomOficina { get; set; }
    }
}
