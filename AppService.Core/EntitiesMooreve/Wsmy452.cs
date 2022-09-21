using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy452
    {
        public int RecnumFactTable { get; set; }
        public int RecnumOriginal { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? ValorLista { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? Orden { get; set; }
        public decimal? BsMc { get; set; }
        public decimal? PorMc { get; set; }
        public decimal? PorCons { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? RecVendedor { get; set; }
        public int? RecProducto { get; set; }
        public int? RecOficina { get; set; }
        public decimal? PorMcFinan { get; set; }
        public string Teamleader { get; set; }
        public decimal? RvalorVenta { get; set; }
        public decimal? RvalorLista { get; set; }
        public decimal? RbsMc { get; set; }
        public decimal? BsMcfinanEmb { get; set; }
        public string CodVendedor { get; set; }
        public string Vendedor { get; set; }
        public string TeamLeader1 { get; set; }
        public string Gerente { get; set; }
        public string TituloOficina { get; set; }
        public string Subcategoria { get; set; }
        public string Categoria { get; set; }
        public int? Idprintnoprint { get; set; }

        public virtual Wsmy453 RecOficinaNavigation { get; set; }
    }
}
