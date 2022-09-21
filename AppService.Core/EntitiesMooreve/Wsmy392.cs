using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Wsmy392
    {
        public decimal Id { get; set; }
        public decimal? Orden { get; set; }
        public decimal? NroNotaCambio { get; set; }
        public string CodTeleop { get; set; }
        public decimal? MesContable { get; set; }
        public decimal? AloContable { get; set; }
        public DateTime? FecRegTeleop { get; set; }
        public string Usuario { get; set; }
        public string Usuariored { get; set; }
    }
}
