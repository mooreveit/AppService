using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwProvisionCliente
    {
        public decimal Id { get; set; }
        public string Cia { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public short? Oficina { get; set; }
        public string NombOfic { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public double An8 { get; set; }
        public string NombreAn8 { get; set; }
        public double? Saldo { get; set; }
        public double? Provision { get; set; }
        public double? Contador { get; set; }
        public double? Posicion { get; set; }
        public int? TipoNegocio { get; set; }
        public double? Rsaldo { get; set; }
        public double? Rprovision { get; set; }
    }
}
