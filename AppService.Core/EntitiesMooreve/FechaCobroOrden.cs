using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class FechaCobroOrden
    {
        public decimal Id { get; set; }
        public decimal? Orden { get; set; }
        public decimal? MontoUsd { get; set; }
        public DateTime? FechaCobro { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? Cliente { get; set; }
        public string UsuarioAgrega { get; set; }
        public DateTime? FechaHoraAgrega { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaHoraModifica { get; set; }
        public decimal? Rtasa { get; set; }
    }
}
