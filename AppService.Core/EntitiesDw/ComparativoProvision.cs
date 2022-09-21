using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class ComparativoProvision
    {
        public double? An8 { get; set; }
        public string NombreAn8 { get; set; }
        public decimal? SaldoProvisionActual { get; set; }
        public decimal? ProvisionActual { get; set; }
        public decimal? SaldoProvisionNueva { get; set; }
        public decimal? ProvisionNueva { get; set; }
        public decimal? Diferencia { get; set; }
        public string Titulo { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int? Oficina { get; set; }
        public string NombreOficina { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public double? IdAn8 { get; set; }
        public decimal? RsaldoProvisionActual { get; set; }
        public decimal? RprovisionActual { get; set; }
        public decimal? RsaldoProvisionNueva { get; set; }
        public decimal? RprovisionNueva { get; set; }
        public decimal? Rdiferencia { get; set; }
    }
}
