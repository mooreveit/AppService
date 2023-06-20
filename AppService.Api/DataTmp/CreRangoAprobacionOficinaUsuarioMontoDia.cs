using System;
using System.Collections.Generic;

namespace AppService.Api.DataTmp
{
    public partial class CreRangoAprobacionOficinaUsuarioMontoDia
    {
        public decimal Id { get; set; }
        public short Oficina { get; set; }
        public string Usuario { get; set; }
        public decimal MontoDesde { get; set; }
        public decimal MontoHasta { get; set; }
        public int DiasDesde { get; set; }
        public int DiasHasta { get; set; }
        public bool Administradora { get; set; }
        public decimal? RmontoDesde { get; set; }
        public decimal? RmontoHasta { get; set; }
    }
}
