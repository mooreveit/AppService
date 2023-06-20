using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesEstadisticas
{
    public partial class VendedoresEstadistico01
    {
        public string CodVendedor { get; set; }
        public string NomVendedor { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public string Oficina { get; set; }
        public string NomOficina { get; set; }
        public string EMail { get; set; }
    }
}
