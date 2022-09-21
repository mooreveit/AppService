using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwDashboardVendedor
    {
        public int Año { get; set; }
        public int Mes { get; set; }
        public string CodigoVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string CodigoSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public decimal? VentaGeneral { get; set; }
        public decimal? VentaCategoria1 { get; set; }
        public decimal? VentaCategoria2 { get; set; }
        public decimal? VentaCategoria3 { get; set; }
        public decimal? VentaCategoria4 { get; set; }
        public decimal? VentaCategoria5 { get; set; }
        public decimal? VentaCategoria6 { get; set; }
        public decimal? VentaCategoria7 { get; set; }
        public decimal? VentaCategoria8 { get; set; }
        public decimal? VentaCategoria9 { get; set; }
        public decimal? VentaCategoria10 { get; set; }
        public decimal? BsMcGeneral { get; set; }
        public decimal? BsMcCategoria1 { get; set; }
        public decimal? BsMcCategoria2 { get; set; }
        public decimal? BsMcCategoria3 { get; set; }
        public decimal? BsMcCategoria4 { get; set; }
        public decimal? BsMcCategoria5 { get; set; }
        public decimal? BsMcCategoria6 { get; set; }
        public decimal? BsMcCategoria7 { get; set; }
        public decimal? BsMcCategoria8 { get; set; }
        public decimal? BsMcCategoria9 { get; set; }
        public decimal? BsMcCategoria10 { get; set; }
        public int? OrdenesGeneral { get; set; }
        public int? OrdenesCategoria1 { get; set; }
        public int? OrdenesCategoria2 { get; set; }
        public int? OrdenesCategoria3 { get; set; }
        public int? OrdenesCategoria4 { get; set; }
        public int? OrdenesCategoria5 { get; set; }
        public int? OrdenesCategoria6 { get; set; }
        public int? OrdenesCategoria7 { get; set; }
        public int? OrdenesCategoria8 { get; set; }
        public int? OrdenesCategoria9 { get; set; }
        public int? OrdenesCategoria10 { get; set; }
        public string TituloCategoria1 { get; set; }
        public string TituloCategoria2 { get; set; }
        public string TituloCategoria3 { get; set; }
        public string TituloCategoria4 { get; set; }
        public string TituloCategoria5 { get; set; }
        public string TituloCategoria6 { get; set; }
        public string TituloCategoria7 { get; set; }
        public string TituloCategoria8 { get; set; }
        public string TituloCategoria9 { get; set; }
        public string TituloCategoria10 { get; set; }
        public decimal? RncBs { get; set; }
        public int? RncCantidad { get; set; }
        public int? DsoCompañia { get; set; }
        public int? Dso { get; set; }
        public decimal? CobranzaPronostico { get; set; }
        public decimal? CobranzaReal { get; set; }
        public int? ClientesNuevos { get; set; }
        public short? OficinaId { get; set; }
        public string OficinaNombre { get; set; }
        public decimal? CuotaGeneral { get; set; }
        public decimal? CotizadoPendiente { get; set; }
        public decimal? GanadoPeriodo { get; set; }
        public decimal? PronosticoGeneral { get; set; }
        public decimal? ValorListaRnc { get; set; }
        public DateTime? FechaUpdate { get; set; }
    }
}
