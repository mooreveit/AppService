using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Pcsysfile
    {
        public int Id { get; set; }
        public decimal? ToleranciaDesde { get; set; }
        public decimal? ToleranciaHasta { get; set; }
        public decimal? PorcCunplimiento { get; set; }
        public int? DiasClienteNuevo { get; set; }
        public int? DiasClienteReactivado { get; set; }
        public decimal? UmbralOrdenesPignoradas { get; set; }
        public int? DiasPagoDoble { get; set; }
    }
}
